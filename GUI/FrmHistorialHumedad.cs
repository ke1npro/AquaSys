using BLL;
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
    public partial class FrmHistorialHumedad : Form
    {
        public FrmHistorialHumedad()
        {
            InitializeComponent();
            dgvHumedad.DataSource = HumedadService.Obtener();
            dgvHumedad.ReadOnly=true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvHumedad.DataSource=HumedadService.Obtener();
        }
    }
}
