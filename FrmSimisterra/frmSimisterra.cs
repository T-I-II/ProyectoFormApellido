using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmSimisterra
{
    public partial class frmSimisterra : Form
    {
        public frmSimisterra()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Hola, Soy Chrisbel Simisterra que tengas ún maravilloso día... ");
        }
    }
}
