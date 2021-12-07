using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFormApellido.Matrices
{
    public partial class frmCervantes : Form
    {
        TextBox[] matriz1 = new TextBox[50];
        TextBox[] matriz2 = new TextBox[50];
        public frmCervantes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMatriz1_Click(object sender, EventArgs e)
        {
            //cracion de controles en tiempo de ejecucíón
           


            int filas = int.Parse(this.txtfila1.Text);
            int cols = int.Parse(this.txtcolumna1.Text);
            int x = 30, y = 280;
            for (int i =0; i < (filas*cols); i++)
            {
                matriz1[i] = new TextBox();
                matriz1[i].Text = (i + 1).ToString();
                matriz1[i].Width = 40; //ancho del control
                matriz1[i].Location = new Point(x, y);
                this.Controls.Add(matriz1[i]);
                x += 42;
                if((i+1) % cols == 0)
                {
                    y += 30;
                    x = 30;
                }

            }
           
        }

        private void btnMatriz2_Click(object sender, EventArgs e)
        {
            TextBox[] matriz2=new TextBox[50];


            int filas = int.Parse(this.txtfila2.Text);
            int cols = int.Parse(this.txtcolumna2.Text);
            int x = 270, y = 280;
            for (int i = 0; i < (filas * cols); i++)
            {
                matriz2[i] = new TextBox();
                matriz2[i].Text = (i + 1).ToString();
                matriz2[i].Width = 40; //ancho del control
                matriz2[i].Location = new Point(x, y);
                this.Controls.Add(matriz2[i]);
                x += 42;
                if ((i + 1) % cols == 0)
                {
                    y += 30;
                    x = 270;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[][] m1 = new int[3][];
            m1[0] = new int[3];
            m1[1] = new int[3];
            m1[2] = new int[3];
            int columnas = int.Parse(this.txtcolumna1.Text);
            int i = 0, j = 0;
            for (int k = 0; k < 9; k++)
            {
                m1[i][j] = int.Parse(matriz1[k].Text);
                j++;
                if ((k+1)% columnas == 0)
                {
                    i++;
                    j = 0;
                }
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.Write($"{m1[i][j]}");

                    }
                    Console.WriteLine();
                }
            }


        }
    }
}
