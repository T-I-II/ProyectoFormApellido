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
    public partial class FrmAldas : Form
    {
        public FrmAldas()
        {
            InitializeComponent();
        }

        private void BtnPresentacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, soy Victor Aldás.....");
        }
    }
}
