using BLL;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmPrincipal : Form
    {
        static int debug;
        ParametroService parametroService;
        HumedadService humedadService;
        public FrmPrincipal()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Enabled = true;
            parametroService = new ParametroService();
            humedadService = new HumedadService();
        }

        

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Parametros parametro =parametroService.Obtener();
            if (parametro == null)
            {
                MessageBox.Show("No se ha configurado el programa! Favor insertar datos antes de continuar");
                FrmConfigurar f = new FrmConfigurar();
                f.ShowDialog();
                Parametros param=f.ObtenerParametro();
                parametroService.Guardar(param);
                RefrescarParametro();
            }
            else
            {
                RefrescarParametro();
            }
        }

        private void RefrescarParametro()
        {
            Parametros parametro = parametroService.Obtener();
            if (parametro != null)
            {
                
                lblEspecie.Text = parametro.Planta.Nombre;
                lblArea.Text = parametro.Area.ToString();
                float HumedadMinima = parametro.Planta.HumedadMinima;
                float HumedadMaxima = parametro.Planta.HumedadMinima;
                LogicaPrincipal.EstablecerUmbral(HumedadMinima, HumedadMaxima, 20);
                LogicaPrincipal.RegarActivo = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHumedad.Text = LogicaPrincipal.HumedadActual.ToString()+"%";

            int count = 0;
            if (count > 15)
            {

            }
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            FrmConfigurar f = new FrmConfigurar();
            f.ShowDialog();

            f.Dispose();
            RefrescarParametro();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Load(openFileDialog1.FileName);
        }
    }
}
