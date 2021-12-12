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
        TextBox[] matriz2 = new TextBox[50];
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
            //crear controles de tiempo de ejecucion 
            int filas = int.Parse(this.TxtFilas2.Text);
            int cols = int.Parse(this.TxtCols2.Text);
            int i = 380;
            int y = 300;
            for (int x = 0; x < (filas * cols); x++)
            {
                matriz2[x] = new TextBox();
                matriz2[x].Text = "0";
                matriz2[x].Width = 40; 
                matriz2[x].Location = new Point(i, y);
                this.Controls.Add(matriz2[x]);//mostrar
                i += 42;

                if ((x + 1) % cols == 0)
                {
                    y += 30;
                    i = 380;
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
            int[][] m2 = new int[3][];
            m2[0] = new int[3];
            m2[1] = new int[3];
            m2[2] = new int[3];
            int columnas1 = int.Parse(this.TxtCols1.Text);
            int columnas2 = int.Parse(this.TxtCols2.Text);
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
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    //Console.Write($"{m1[1][1]}"); 
                }
                //Console.WriteLine();
            }
            int a = 0, b = 0;
            for (int l = 0; l < 9; l++)
            {
                m2[a][b] = int.Parse(matriz2[l].Text);
                b++;
                if ((l + 1) % columnas2 == 0)
                {
                    a++;
                    b = 0;
                }
            }
            for (a = 0; a < 3; a++)
            {
                for (b = 0; b < 3; b++)
                {
                    //Console.Write($"{m2[0][0]}");
                }
                //Console.WriteLine();
            }
            //Console.Write($"{m1[0][0] * m2[0][0]}");
            int resul1 = (m1[0][0] * m2[0][0]) + (m1[0][01] * m2[1][0]) + (m1[0][02] * m2[2][0]);
            this.TxtRes1.Text = resul1.ToString();
            int resul2 = (m1[0][0] * m2[0][1]) + (m1[0][01] * m2[01][1]) + (m1[0][02] * m2[2][1]);
            this.TxtRes2.Text = resul2.ToString();
            int resul3 = (m1[0][0] * m2[0][2]) + (m1[0][1] * m2[01][2]) + (m1[0][2] * m2[02][2]);
            this.TxtRes3.Text = resul3.ToString();
            int resul4 = (m1[01][00] * m2[0][0]) + (m1[01][01] * m2[01][0]) + (m1[01][02] * m2[02][0]);
            this.TxtRes4.Text = resul4.ToString();
            int resul5 = (m1[01][00] * m2[0][1]) + (m1[01][01] * m2[01][1]) + (m1[01][02] * m2[02][1]);
            this.TxtRes5.Text = resul5.ToString();
            int resul6 = (m1[01][00] * m2[0][2]) + (m1[01][01] * m2[01][2]) + (m1[01][02] * m2[02][2]);
            this.TxtRes6.Text = resul6.ToString();
            int resul7 = (m1[02][00] * m2[0][0]) + (m1[02][01] * m2[01][0]) + (m1[02][02] * m2[02][0]);
            this.TxtRes7.Text = resul7.ToString();
            int resul8 = (m1[02][00] * m2[0][1]) + (m1[02][01] * m2[01][1]) + (m1[02][02] * m2[02][1]);
            this.TxtRes8.Text = resul8.ToString();
            int resul9 = (m1[02][00] * m2[0][2]) + (m1[02][01] * m2[01][2]) + (m1[02][02] * m2[02][2]);
            this.TxtRes9.Text = resul9.ToString();


        }

    }  
}