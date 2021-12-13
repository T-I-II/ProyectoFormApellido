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
    public partial class frmMatrices_Garcia : Form
    {

       private int[,] m1;
       private int[,] m2;
        private int[,] resp;
        public frmMatrices_Garcia()
        {
            InitializeComponent();
        }

        private void frmMatrices_Garcia_Load(object sender, EventArgs e)
        {

        }

        private void btnMatriz1_Click(object sender, EventArgs e)
        {
            // creación de controles en tiempo de ejecución

          
            int filas = int.Parse(this.txtFilas1.Text);
            int cols = int.Parse(this.txtCols1.Text);
            this.m1 = new int[filas, cols];


            int x = 100;
            int y = 225;

            int count = 1;

            for (int filasaux= 0; filasaux < filas; filasaux++)
            {
                for (int columnasaux = 0; columnasaux < cols; columnasaux++)
                {
                    TextBox aux = new TextBox();
                    this.m1[filasaux,columnasaux] = count++;
                    aux.Width = 40; //ancho del control
                    aux.Text = this.m1[filasaux, columnasaux].ToString();
                    aux.Location = new Point(x, y); //posición del control
                    this.Controls.Add(aux);
                    x = x + (aux.Width + 3);
                }
                y = y + 30;
                x = 100;
            }

        

           

        }

        private void btnMatriz2_Click(object sender, EventArgs e)
        {
          

            int filas = int.Parse(this.txtFilas2.Text);
            int cols = int.Parse(this.txtCols2.Text);
            this.m2 = new int[filas, cols];


            int x = 480;
            int y = 225;

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
                x = 480;
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int filas1 = int.Parse(this.txtFilas1.Text);
            int cols1 = int.Parse(this.txtCols1.Text);
            int filas2 = int.Parse(this.txtFilas2.Text);
            int cols2 = int.Parse(this.txtCols2.Text);


            int x = 290;
            int y = 300;


            if (filas2 == cols1)
            {
                this.resp = new int[filas1, cols2];

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
                        this.resp[filasaux, columnasaux] = suma;
                        aux.Width = 40; //ancho del control
                        aux.Text = this.resp[filasaux, columnasaux].ToString();
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
