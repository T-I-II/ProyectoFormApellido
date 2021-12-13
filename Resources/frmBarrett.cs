using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFormApellido.Resources
{
    public partial class FrmBarrett : Form
    {
        TextBox[] matriz1 = new TextBox[50];
        TextBox[] matriz2 = new TextBox[50];
        public FrmBarrett()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crear controles de tiempo de ejecucion 
            Random elpepe = new Random();
            int n = elpepe.Next(1, 20);
            int filas = int.Parse(this.txtFila1.Text);
            int columnas = int.Parse(this.txtcolum1.Text);
            int i = 30;
            int y = 300;
            for (int x = 0; x < (filas * columnas); x++)
            {
                n= elpepe.Next(1, 20);
                matriz1[x] = new TextBox();
                matriz1[x].Text = n.ToString();
                matriz1[x].Width = 40; //ancho
                matriz1[x].Location = new Point(i, y);//posicion 
                this.Controls.Add(matriz1[x]);//mostrar
                i += 42;

                if ((x + 1) % columnas == 0)
                {
                    y += 30;
                    i = 30;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //crear controles de tiempo de ejecucion 
            Random etesetch = new Random();
            int nu = etesetch.Next(1, 20);
            int filas = int.Parse(this.txtFila2.Text);
            int columnas = int.Parse(this.txtcolum2.Text);
            int i = 380;
            int y = 400;
            for (int x = 0; x < (filas * columnas); x++)
            {
                nu = etesetch.Next(1, 20);
                matriz2[x] = new TextBox();
                matriz2[x].Text = nu.ToString();
                matriz2[x].Width = 40; //ancho
                matriz2[x].Location = new Point(i, y);//posicion 
                this.Controls.Add(matriz2[x]);//mostrar
                i += 42;

                if ((x + 1) % columnas == 0)
                {
                    y += 30;
                    i = 380;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[][] m1 = new int[3][];
            m1[0] = new int[3];
            m1[1] = new int[3];
            m1[2] = new int[3];

            //pasa los elementos del matriz1 a la matriz de los enteros m1
            int columas = int.Parse(this.txtcolum1.Text);
            int i = 0, j = 0;
            for (int x1 = 0; x1 < 9; x1++)
            {
                m1[i][j] = int.Parse(matriz1[x1].Text);
                j++;
                if ((x1 + 1) % columas == 0)
                {
                    i++;
                    j = 0;
                }


            }
            //imprimiar
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

