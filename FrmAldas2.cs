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
    public partial class FrmAldas2 : Form
    {
        TextBox[] matriz1 = new TextBox[50];
        public FrmAldas2()
        {
            InitializeComponent();
        }

        private void BtmMatriz1_Click(object sender, EventArgs e)
        {
            // cracion de controles en tiempo de ejecutacion

            int filas = int.Parse(this.TxtFilas1.Text);
            int cols = int.Parse(this.TxtCols1.Text);
            int x = 50, y = 280;
            for (int i = 0; i < (filas * cols); i++)
            {
                matriz1[i] = new TextBox();
                matriz1[i].Text = i.ToString();
                matriz1[i].Width = 40;
                matriz1[i].Location = new Point(x, y);
                this.Controls.Add(matriz1[i]);
                x += 42;
                if ((i + 1) % cols == 0)
                {
                    y += 30;
                    x = 50;
                }

            }

        }

        private void BtnMatriz2_Click(object sender, EventArgs e)
        {
            {
                // cracion de controles en tiempo de ejecutacion
                TextBox[] matriz1 = new TextBox[50];
                int filas = int.Parse(this.TxtFilas2.Text);
                int cols = int.Parse(this.TxtCols2.Text);
                int x = 50, y = 280;
                for (int i = 0; i < (filas * cols); i++)
                {
                    matriz1[i] = new TextBox();
                    matriz1[i].Text = "0";
                    matriz1[i].Width = 40;
                    matriz1[i].Location = new Point(x, y);
                    this.Controls.Add(matriz1[i]);
                    x += 42;
                    if ((i + 1) % cols == 0)
                    {
                        y += 30;
                        x = 50;
                    }
                }
            }
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            //se asume matrices 3 x 3
            int[][] m1 = new int[3][];
            m1[0] = new int[3];
            m1[1] = new int[3];
            m1[2] = new int[3];

            int cols = int.Parse(this.TxtCols1. Text);
            int i = 0, j = 0;
            for (int k = 0; k < 9; k++)
            {
                m1[i][j] = int.Parse(matriz1[k].Text);
                j++;
                if((k+1) % cols ==0)
                {
                    i++;
                    j = 0;
                }
            }
            for (i=0; i<3;i++)

            {
                for(j=0;j<3;j++)
                {
                    Console.Write($"{ m1[i][j]}");
                }
                Console.WriteLine();

            }

        }
    }
}