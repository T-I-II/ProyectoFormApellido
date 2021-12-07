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
    public partial class FrmCervantes : Form
    {
        public FrmCervantes()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido, mi nombre es Iván Cervantes tengo 18 años y soy estudiante de la PUCESE en la Carrera Tecnología de la Información...");
        }
    }
}
