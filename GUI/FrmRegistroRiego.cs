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
    public partial class FrmRegistroRiego : Form
    {
        public FrmRegistroRiego()
        {
            InitializeComponent();
            dgvRegistroRiego.DataSource = RiegoService.ObtenerTodo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvRegistroRiego.DataSource = null;
            dgvRegistroRiego.DataSource = RiegoService.ObtenerTodo();
        }
    }
}
