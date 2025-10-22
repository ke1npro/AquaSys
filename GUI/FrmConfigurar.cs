using BLL;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmConfigurar : Form
    {
        PlantaService plantaService;
        ParametroService parametroService;
        Planta PlantaSeleccionada;
        List<Planta> lista;
        public FrmConfigurar()
        {
            InitializeComponent();
            plantaService = new PlantaService();
            parametroService = new ParametroService();
            lista = plantaService.ObtenerTodo();
            dgvPlantas.DataSource = plantaService.ObtenerTodo();
            dgvPlantas.ReadOnly=true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validar
           
            
            if (txtId.Text == null || txtNombre.Text == null)
            {
                MessageBox.Show("Los campos no pueden ser vaciós");
                return;
            }

    
            if (!int.TryParse(txtId.Text, out int id) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("ID o nombre inválido.");
                return ;
            }

            float humedadMax = (float)nudHumedadMaxima.Value;
            float humedadMin = (float)nudHumedadMinima.Value;

            // Validar rango de humedad
            if (humedadMin < 0 || humedadMax > 100 || humedadMin >= humedadMax)
            {
                MessageBox.Show("Error: El rango de humedad debe estar entre 0 y 100, y la mínima debe ser menor que la máxima.");
                return ;
            }
            if (plantaService.ObtenerPorId(int.Parse(txtId.Text))!=null){
                MessageBox.Show("Ya existe esta planta");
                return;
            }
            Planta planta = new Planta(); 
            planta.Id = int.Parse(txtId.Text); 
            planta.Nombre = txtNombre.Text; 
            planta.HumedadMaxima = (float)nudHumedadMaxima.Value; 
            planta.HumedadMinima= (float)nudHumedadMinima.Value;
            string mensaje=plantaService.Agregar(planta);
            MessageBox.Show(mensaje);

        }

        private void FrmConfigurar_Load(object sender, EventArgs e)
        {
            Parametros parametro =parametroService.Obtener();
            if (parametro != null)
            {
                PlantaSeleccionada = parametro.Planta;
            }
        }

        private void tabListadoPlantas_Enter(object sender, EventArgs e)
        {
            lista = plantaService.ObtenerTodo();
            dgvPlantas.DataSource = lista;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            var aux = dgvPlantas.CurrentRow;
            int id = int.Parse(aux.Cells[0].Value.ToString());
            PlantaSeleccionada = plantaService.ObtenerPorId(id);
            parametroService.Guardar(ObtenerParametro());
        }

        private Parametros ObtenerParametro()
        {
            Parametros parametro = new Parametros();
            parametro.AsignarPlanta(PlantaSeleccionada);
            parametro.Area = (int)nudArea.Value;
            return parametro;
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
