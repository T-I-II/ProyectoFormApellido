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
    public partial class frmMatrices_Santana : Form
    {
        TextBox[] matriz1 = new TextBox[50];
        TextBox[] matriz2 = new TextBox[50];
        public frmMatrices_Santana()
        {
            InitializeComponent();
        }

        private void frmMatrices_Santana_Load(object sender, EventArgs e)
        {

        }

        private void btn_M1_Click(object sender, EventArgs e)
        {
            //crear controles de tiempo de ejecucion 
            
            int filas = int.Parse(this.txt_F1_M1.Text);
            int columnas = int.Parse(this.txt_C1_M1.Text);
            int i = 30;
            int y = 300;
            for (int x = 0; x < (filas*columnas); x++)
            {
                matriz1[x] = new TextBox();
                matriz1[x].Text = "0";
                matriz1[x].Width = 40; //ancho
                matriz1[x].Location = new Point(i, y);//posicion 
                this.Controls.Add(matriz1[x]);//mostrar
                i += 42;
                
                if((x+1) % columnas == 0)
                {
                    y += 30;
                    i = 30;
                }
            }
            MessageBox.Show("Matriz creada");
        }

        private void btn_M2_Click(object sender, EventArgs e)
        {
            //crear controles de tiempo de ejecucion 
            TextBox[] matriz2 = new TextBox[50];
            int filas = int.Parse(this.txt_F2_M2.Text);
            int columnas = int.Parse(this.txt_C2_M2.Text);
            int i = 380;
            int y = 300;
            for (int x = 0; x < (filas * columnas); x++)
            {
                matriz2[x] = new TextBox();
                matriz2[x].Text = "0";
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
            MessageBox.Show("Matriz creada");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int[][] m1 = new int[3][];
            m1[0] = new int [3];
            m1[1] = new int[3];
            m1[2] = new int[3];

            //pasa los elementos del matriz1 a la matriz de los enteros m1
            int columas = int.Parse(this.txt_C1_M1.Text);
            int i = 0, j = 0;
            for(int x1=0; x1<9; x1++)
            {
                m1[i][j] = int.Parse(matriz1[x1].Text);
                j++;
                if((x1 + 1) % columas == 0)
                {
                    i++;
                    j = 0;
                }
                

            }
            //imprimiar
            for(i = 0; i<3; i ++)
            {
                for (j = 0; j < 3; j++){
                Console.Write($"{m1[i][j]}");
            }
            Console.WriteLine();
            }
        }
    }
}
