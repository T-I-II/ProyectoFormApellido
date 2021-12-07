using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFormApellido
{
    public partial class FrmJunco : Form
    {
        public FrmJunco()
        {
            InitializeComponent();
        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola a todos <3");
        }
    }
}
