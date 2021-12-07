using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFormApellido.Matrices_Cagua
{
    public partial class frmaMatrices_Cagua : Form
    {
        TextBox[] matriz1 = new TextBox[50];
        public frmaMatrices_Cagua()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMatriz2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMatriz1_Click(object sender, EventArgs e)
        {
            //creacion de controles en tiempo de ejecucion
            
            int filas = int.Parse(this.txtFilas1.Text);
            int cols = int.Parse(this.txtCols1.Text);
            int x = 35, y = 250;
            for(int i=0; i<9; i++)
            {
                matriz1[0] = new TextBox();
                matriz1[0].Text = "0";
                matriz1[0].Width = 40; //ancho del control
                matriz1[0].Location = new Point(x, y);//posicion del control
                this.Controls.Add(matriz1[0]);//mostrar el control
                x += 42;
                if ((i+1)% cols ==0)
                {
                    y += 30;
                    x -= 126;
                }

            }

            
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //se suma unamatriz de 3x3
            int[][] m1 = new int[3][];
            m1[0] = new int[3];
            m1[1] = new int[3];
            m1[2] = new int[3];
            int i = 0, j = 0;
            for(int k=0;  k<9; k++)
            {
                m1[i][j] = int.Parse(matriz1[k].Text);
                j++;
                if ((k+1)% Cols1 ==0)
                {
                    i++;
                    j = 0;
                }
            }

            //imprime la matriz m1
            for(i=0; i<3; i++)
            {
                for(j=0; j<3; j++)
                {
                    Console.Write($"{m1[i][j]}");
                }
                Console.WriteLine();            }
        }
    }
}
