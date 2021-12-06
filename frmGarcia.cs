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
    public partial class frmGarcia : Form
    {
        public frmGarcia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Holaa, que tal ? Saludo desde el más allá :D, Jefferson Garcia");
        }

        private void frmGarcia_Load(object sender, EventArgs e)
        {

        }
    }
}
