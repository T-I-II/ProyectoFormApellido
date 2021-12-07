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
    public partial class FrnDiaz : Form
    {
        TextBox[] matriz1 = new TextBox[50];
        TextBox[] matriz2 = new TextBox[50];
        public FrnDiaz()
        {
            InitializeComponent();
        }

        private void btnMatriz1_Click(object sender, EventArgs e)
        {
            //creacion de controles en tiempo de ejecucion
            

            int filas = int.Parse(this.txtFilas1.Text);
            int cols = int.Parse(this.txtcols1.Text);
            int x = 30, y = 280;
            for (int i = 0; i < (filas * cols); i++)
            {
                matriz1[i] = new TextBox();
                matriz1[i].Text = i.ToString();
                matriz1[i].Width = 40; //ancho de control
                matriz1[i].Location = new Point(x, y);//posicion del control
                this.Controls.Add(matriz1[i]); //mostrar el control
                x += 44;
                if ((i + 1) % cols == 0)
                {
                    y += 30;
                    x = 30;
                }
            }

        }

        private void btnMatriz2_Click(object sender, EventArgs e)
        {
            //creacion de controles en tiempo de ejecucion
           

            int filas = int.Parse(this.txtFilas2.Text);
            int cols = int.Parse(this.txtcls2.Text);
            int x = 350, y = 280;
            for (int i = 0; i < (filas * cols); i++)
            {
                matriz1[i] = new TextBox();
                matriz1[i].Text = "0";
                matriz1[i].Width = 40; //ancho de control
                matriz1[i].Location = new Point(x, y);//posicion del control
                this.Controls.Add(matriz1[i]); //mostrar el control
                x += 44;
                if ((i + 1) % cols == 0)
                {
                    y += 30;
                    x = 350;
                }
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int[][] m1 = new int[3][];
            m1[0] = new int[3];
            m1[1] = new int[3];
            m1[2] = new int[3];
            int columnas = int.Parse(this.txtcols1.Text);
            int i = 0, j = 0;
            //HOLA
            for(int k=0; k<9; k++)
            {
                m1[i][j] = int.Parse(matriz1[k].Text);
                j++;
                if((k + 1)% columnas == 0)
                {
                    i++;
                    j = 0;
                }
            }
            for(i=0; i<3; i++)
            {
                for(j=0; j<3; j++)
                {
                    Console.Write($"{m1[i][j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
