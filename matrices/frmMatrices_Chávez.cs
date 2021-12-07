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
            int x = 250, y = 270;
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
                    x = 250;
                }
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int[][] m1 = new int[3][];
            m1[0] = new int[3];
            m1[1] = new int[3];
            m1[2] = new int[3];
            int columnas = int.Parse(this.txtCols1.Text);
            int i = 0, j = 0;
            for (int k = 0; k < 9; k++)
            {
                m1[i][j] = int.Parse(Matriz1[k].Text);
                j++;
                if ((k + 1) % columnas == 0)
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
