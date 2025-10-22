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
        int count = 0;
        public FrmPrincipal()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            parametroService = new ParametroService();
            

        }



        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Parametros parametro =parametroService.Obtener();
            if (parametro == null)
            {
                MessageBox.Show("No se ha configurado el programa! Favor insertar datos antes de continuar");
                FrmConfigurar f = new FrmConfigurar();
                f.ShowDialog();
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
                float HumedadMaxima = parametro.Planta.HumedadMaxima;
                LogicaPrincipal.EstablecerUmbral(HumedadMinima, HumedadMaxima, 10);
                LogicaPrincipal.RegarActivo = true;
                label4.Text = HumedadMaxima.ToString("F1")+"%";
                label5.Text = HumedadMinima.ToString("F1") + "%";

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHumedad.Text = LogicaPrincipal.HumedadActual.ToString()+"%";

            bool estado = LogicaPrincipal.EstaRegando;
            if (estado)
            {
                lblEstado.Text = "Regando";
            }
            else
            {
                lblEstado.Text = "Inactivo";
            }

            
            count++;
            if (count > 1)
            {
                Console.WriteLine("Registrando humedad");
                Humedad humedad = new Humedad();
                humedad.Fecha = DateTime.Now;
                humedad.Porcentaje = LogicaPrincipal.HumedadActual;
                HumedadService.Agregar(humedad);
                count = 0;
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
            try
            {
                pictureBox1.Load(openFileDialog1.FileName);
             }catch(Exception h)
            {

            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorialHumedad f = new FrmHistorialHumedad();
            f.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FrmRegistroRiego f = new FrmRegistroRiego();
            f.ShowDialog();
        }
    }
}
