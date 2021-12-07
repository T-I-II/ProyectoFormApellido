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
    public partial class frmChávez : Form
    {
        public frmChávez()
        {
            InitializeComponent();
        }

        private void btnSALUDAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, soy Lisbeth Chávez Quiñónez");
        }
    }
}
