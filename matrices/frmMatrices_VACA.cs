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
        private int[,] m1;
        private int[,] m2;
        private int[,] finmatriz;

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


            int filas = int.Parse(this.txtNFilas1.Text);
            int cols = int.Parse(this.txtNColumnas1.Text);
            this.m1 = new int[filas, cols];


            int x = 40;
            int y = 290;

            int count = 1;

            for (int filasaux = 0; filasaux < filas; filasaux++)
            {
                for (int columnasaux = 0; columnasaux < cols; columnasaux++)
                {
                    TextBox aux = new TextBox();
                    this.m1[filasaux, columnasaux] = count++;
                    aux.Width = 40; //ancho del control
                    aux.Text = this.m1[filasaux, columnasaux].ToString();
                    aux.Location = new Point(x, y); //posición del control
                    this.Controls.Add(aux);
                    x = x + (aux.Width + 3);
                }
                y = y + 30;
                x = 40;
            }
        }

        private void frmMatrices_VACA_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearM2_Click(object sender, EventArgs e)
        {
            int filas = int.Parse(this.txtNFilas2.Text);
            int cols = int.Parse(this.txtNColumnas2.Text);
            this.m2 = new int[filas, cols];


            int x = 420;
            int y = 300;

            int count = 1;

            for (int filasaux = 0; filasaux < filas; filasaux++)
            {
                for (int columnasaux = 0; columnasaux < cols; columnasaux++)
                {
                    TextBox aux = new TextBox();
                    this.m2[filasaux, columnasaux] = count++;
                    aux.Width = 40; //ancho del control
                    aux.Text = this.m2[filasaux, columnasaux].ToString();
                    aux.Location = new Point(x, y); //posición del control
                    this.Controls.Add(aux);
                    x = x + (aux.Width + 3);
                }
                y = y + 30;
                x = 420;
            }
        }

        private void btnMultiplicarMatrices_Click(object sender, EventArgs e)
        {
            int filas1 = int.Parse(this.txtNFilas1.Text);
            int cols1 = int.Parse(this.txtNColumnas1.Text);
            int filas2 = int.Parse(this.txtNFilas2.Text);
            int cols2 = int.Parse(this.txtNColumnas2.Text);


            int x = 290;
            int y = 450;


            if (filas2 == cols1)
            {
                this.finmatriz = new int[filas1, cols2];

                for (int filasaux = 0; filasaux < filas1; filasaux++)
                {
                    for (int columnasaux = 0; columnasaux < cols2; columnasaux++)
                    {
                        int suma = 0;

                        for (int filas2aux = 0; filas2aux < filas2; filas2aux++)
                        {

                            suma = suma + (this.m1[filasaux, filas2aux] * this.m2[filas2aux, columnasaux]);

                        }

                        TextBox aux = new TextBox();
                        this.finmatriz[filasaux, columnasaux] = suma;
                        aux.Width = 40; //ancho del control
                        aux.Text = this.finmatriz[filasaux, columnasaux].ToString();
                        aux.Location = new Point(x, y); //posición del control
                        this.Controls.Add(aux);
                        x = x + (aux.Width + 3);

                    }
                    y = y + 30;
                    x = 290;
                }



            }
            else
            {
                MessageBox.Show("No cumple, los requisitos para multiplicar");
            }
        }
    }
}
