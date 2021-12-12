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
    public partial class frmMatrices_Chávez : Form
    {
        TextBox[] Matriz1 = new TextBox[50];
        TextBox[] Matriz2 = new TextBox[50];
        TextBox[] OperacionResultado = new TextBox[50];
        public frmMatrices_Chávez()
        {
            InitializeComponent();
        }

        private void btnMatriz1_Click(object sender, EventArgs e)
        {            
            int filas = int.Parse(this.txtFilas1.Text);
            int cols = int.Parse(this.txtCols1.Text);
            int x = 30, y = 220;
            for (int i = 0; i < (filas * cols); i++)
            {
                Matriz1[i] = new TextBox();
                Matriz1[i].Text = (i + 1).ToString();
                Matriz1[i].Width = 40; //
                Matriz1[i].Location = new Point(x, y);
                this.Controls.Add(Matriz1[i]);
                x += 42;
                if ((i + 1) % cols == 0)
                {
                    y += 30;
                    x = 30;
                }

            }
        }

        private void btnMatriz2_Click(object sender, EventArgs e)
        {
            TextBox[] Matriz2 = new TextBox[50];


            int filas = int.Parse(this.txtFilas2.Text);
            int cols = int.Parse(this.txtCols2.Text);
            int x = 280, y = 290;
            for (int i = 0; i < (filas * cols); i++)
            {
                Matriz2[i] = new TextBox();
                Matriz2[i].Text = (i + 1).ToString();
                Matriz2[i].Width = 40; //ancho del control
                Matriz2[i].Location = new Point(x, y);
                this.Controls.Add(Matriz2[i]);
                x += 42;
                if ((i + 1) % cols == 0)
                {
                    y += 30;
                    x = 280;
                }
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int[][] m1 = new int[3][];
            m1[0] = new int[3];
            m1[1] = new int[3];
            m1[2] = new int[3];
            int[][] m2 = new int[3][];
            m2[0] = new int[3];
            m2[1] = new int[3];
            m2[2] = new int[3];
            int columnas1 = int.Parse(this.txtCols1.Text);
            int columnas2= int.Parse(this.txtCols2.Text);
            int i = 0;
            int j = 0;
            for (int k = 0; k < 9; k++)
            {
                m1[i][j] = int.Parse(Matriz1[k].Text);
                j++;
                if ((k + 1) % columnas1 == 0)
                {
                    i++;
                    j = 0;
                }
            }
            for (i = 0; i < 3; i++)
            {
               for (j = 0; j < 3; j++)
               {
                 Console.Write($"{m1[i][j]}");

               }
               Console.WriteLine();
            }

            int w = 0;
            int z= 0;
            for (int l = 0; l < 9; l++)
            {
                m2[w][z] = int.Parse(Matriz2[l].Text);
                z++;
                if ((l + 1) % columnas2 == 0)
                {
                    w++;
                    z = 0;
                }
            }
            for (w = 0; w < 3; w++)
            {
                for (z = 0; z < 3; z++)
                {
                    Console.Write($"{m2[0][0]}");
                }
                Console.WriteLine();
            }
            int f=0;
            int c=0;
            int c2=0;
            ResultadoMatrices m1;
            ResultadoMatrices m2;
            ResultadoMatrices resultado;

            for(int i=0;i<f;i++)
            {
                for(j=0;j<c2;j++)
                {
                    resultado[j,i].Value=0;
                    for(k=0;k<c;k++)
                    {
                        resultado[j,i].Value=Convert.ToInt32(resultado[j,i].Value)+Convert.ToInt32(m1[k,i].Value)*Convert.ToInt32(m2[j,k].Value);
                    }
                }
            }
           

            }        
        }
    }
}
