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
    public partial class frmMatrices_VACA : Form
    {
        public frmMatrices_VACA()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrearM1_Click(object sender, EventArgs e)
        {
            // creación de controles en tiempo de ejecución
            TextBox[] matriz1 = new TextBox[50];
            int filas = int.Parse(this.txtNFilas1.Text);
            int columnas = int.Parse(this.txtNColumnas1.Text);
            int x = 50, y=290;
            for(int i = 0; i<(filas*columnas); i++)
            {
            matriz1[1] = new TextBox();
            matriz1[1].Text = "0";
            matriz1[1].Width = 40; //ancho del control
            matriz1[1].Location = new Point(x, y); // Posición del control
            this.Controls.Add(matriz1[1]); //Mostrar el control
                x += 42;
                if ((i+1) % columnas == 0)
                {
                    y += 20;
                    x = 50;
                }
            }
        }

        private void frmMatrices_VACA_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearM2_Click(object sender, EventArgs e)
        {
            // creación de controles en tiempo de ejecución
            TextBox[] matriz2 = new TextBox[50];
            int filas = int.Parse(this.txtNFilas2.Text);
            int columnas = int.Parse(this.txtNColumnas2.Text);
            int x = 420, y = 290;
            for (int i = 0; i < (filas * columnas); i++)
            {
                matriz2[1] = new TextBox();
                matriz2[1].Text = "0";
                matriz2[1].Width = 40; //ancho del control
                matriz2[1].Location = new Point(x, y); // Posición del control
                this.Controls.Add(matriz2[1]); //Mostrar el control
                x += 42;
                if ((i + 1) % columnas == 0)
                {
                    y += 20;
                    x = 420;
                }
            }
        }

        private void btnMultiplicarMatrices_Click(object sender, EventArgs e)
        {
            TextBox[] matriz1 = new TextBox[50];
            // se asume una matriz de 3x3
            int[][] m1 = new int[3][];
            m1[0] = new int[3];
            m1[1] = new int[3];
            m1[2] = new int[3];

            //pasa los elementos de la matriz1 a la matriz enteros m1
            int columna = int.Parse(this.txtNColumnas1.Text);
            int i = 0, j = 0; 

            for (int k = 0; k < 9; k++)
            {
                m1[i][j] = int.Parse(matriz1[k].Text);
                j++;
                if ((k+1) % columna == 0)
                {
                    i++;
                    j = 0;
                }
            }

            // imprime la matriz m1
            for (i=0; i<3; i++)
            {
                for (j=0; j<3; j++)
                {
                    Console.Write($"{m1[i][j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
