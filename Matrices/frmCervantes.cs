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
            for (int i = 0; i < (filas * cols); i++)
            {
                matriz1[i] = new TextBox();
                matriz1[i].Text = (i + 1).ToString();
                matriz1[i].Width = 40; //ancho del control
                matriz1[i].Location = new Point(x, y);
                this.Controls.Add(matriz1[i]);
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
            TextBox[] matriz2 = new TextBox[50];


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
            int[][] m2 = new int[3][];
            m2[0] = new int[3];
            m2[1] = new int[3];
            m2[3] = new int[3];
            int columnas1 = int.Parse(this.txtcolumna1.Text);
            int columnas2 = int.Parse(this.txtcolumna2.Text);
            int i = 0, j = 0;
            for (int k = 0; k < 9; k++)
            {
                m1[i][j] = int.Parse(matriz1[k].Text);
                j++;
                if ((k + 1) % columnas1 == 0)
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
                int w = 0;
                int z = 0;
                for (int r = 0; r < 9; r++)
                {
                    m2[w][z] = int.Parse(matriz2[1].Text);
                    z++;
                    if ((1 + 1) % columnas2 == 0)
                    {
                        w++;
                        z = 0;
                    }
                    for (w = 0; w < 3; w++)
                    {
                        for (z = 0; z < 9; z++)
                        {
                            Console.Write($"{m2[0][0]}");
                        }
                        Console.WriteLine();
                    }
                    int f = 0;
                    int c = 0;
                    int c2 = 0;
                    this.Resultado m1;
                    this.Resultado m2;
                    this.Resultado resultado;

                    for (int i = 0; i < f; i++)
                    {
                        for (j = 0; j < c2; j++)
                        {
                            Resultado[j, i].Value = 0;
                            for (k = 0; k < c; k++)
                            {
                                Resultado[j, i].Value = Convert.ToInt32(Resultado[j, i].Value) + Convert.ToInt32(m1[k, i].Value) * Convert.ToInt32(m2[j, k].Value);
                            }
                        }
                    }


                }
            }
        }
    }