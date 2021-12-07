using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFormApellido.matrices
{
    public partial class frmMatrices_Garcia : Form
    {
        TextBox[] matriz1 = new TextBox[50];
        public frmMatrices_Garcia()
        {
            InitializeComponent();
        }

        private void frmMatrices_Garcia_Load(object sender, EventArgs e)
        {

        }

        private void btnMatriz1_Click(object sender, EventArgs e)
        {
            // creación de controles en tiempo de ejecución

            int[] m1 = new int[40];
            int filas = int.Parse(this.txtFilas1.Text);
            int cols = int.Parse(this.txtCols1.Text);
            int x = 55;
            int y = 225;
            int mutl = filas * cols;
            for (int i= 0; i<(mutl); i++)
            {
                matriz1[i] = new TextBox();
                matriz1[i].Text = (i + 1).ToString();
                matriz1[i].Width = 40; //ancho del control
                matriz1[i].Location = new Point(x, y); //posición del control
                this.Controls.Add(matriz1[i]);
                x += 50;
                if ((i + 1) % cols == 0)
                {
                    y += 23;
                    x = 55;
                }
            }

           

        }

        private void btnMatriz2_Click(object sender, EventArgs e)
        {
            TextBox[] matriz2 = new TextBox[50];
            int[] m2 = new int[40];
            int filas2 = int.Parse(this.txtFilas2.Text);
            int cols2 = int.Parse(this.txtCols2.Text);
            int x2 = 450;
            int y2 = 225;
            int mutl2 = filas2 * cols2;
            for (int i = 0; i < (mutl2); i++)
            {
                matriz2[i] = new TextBox();
                matriz2[i].Text = (i + 1).ToString();
                matriz2[i].Width = 40; //ancho del control
                matriz2[i].Location = new Point(x2, y2); //posición del control
                this.Controls.Add(matriz2[i]);
                x2 += 50;
                if ((i + 1) % cols2 == 0)
                {
                    y2 += 23;
                    x2 = 150;
                }
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //se asume una matriz de 3 x 3
            int[][] m1 = new int[3][];
            m1[0] = new int[3];
            m1[1] = new int[3];
            m1[2] = new int[3];

            //pasa los elementos de la matriz1 a la matriz de enteros m1
            int cols = int.Parse(this.txtCols1.Text);
            int i = 0, j = 0;
            for(int k=0; k<9; k++)
            {
                m1[i][j] = int.Parse(matriz1[k].Text);
                j++;
                if ((k + 1) % cols == 0)
                {
                    i++;
                    j = 0;
                }
            }

            //imprime la matriz m1
            for(i=0; i<3; i++)
            {
                for(j=0; i<3; i++)
                {
                    Console.WriteLine($"{m1[i][j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
