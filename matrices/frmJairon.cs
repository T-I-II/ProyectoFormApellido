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
    public partial class frmJairon : Form
    {
        TextBox[] matriz1 = new TextBox[50];
        TextBox[] matriz2 = new TextBox[50];
        public frmJairon()
        {
            InitializeComponent();
        }

        private void btnMatriz1_Click(object sender, EventArgs e)
        {
            int filas = int.Parse(this.textFilas1.Text);
            int columnas = int.Parse(this.textColumnas1.Text);
            int x = 60, y=280;
            for (int i = 0; i < (filas*columnas); i++)
            {
                matriz1[i] = new TextBox();
                matriz1[i].Text = " ";//(i +1).ToString();
                matriz1[i].Width = 40;
                matriz1[i].Location = new Point(x, y);
                this.Controls.Add(matriz1[i]);
                x += 44;
                if ((i+1) % columnas == 0)
                {
                    y += 30;
                    x = 60;
                }
            }

        }

        private void btnMatriz2_Click(object sender, EventArgs e)
        {

            int filas = int.Parse(this.textFilas2.Text);
            int columnas = int.Parse(this.textColumnas2.Text);
            int x = 250, y = 280;
            for (int i = 0; i < (filas * columnas); i++)
            {
                matriz2[i] = new TextBox();
                matriz2[i].Text = " ";//(i + 1).ToString();
                matriz2[i].Width = 40;
                matriz2[i].Location = new Point(x, y);
                this.Controls.Add(matriz2[i]);
                x += 44;
                if ((i + 1) % columnas == 0)
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
            int[][] m2 = new int[3][];
            m2[0] = new int[3];
            m2[1] = new int[3];
            m2[2] = new int[3];
            int columnas1 = int.Parse(this.textColumnas1.Text);
            int columnas2 = int.Parse(this.textColumnas2.Text);
            int i = 0,j= 0;
            for(int k=0; k < 9; k++)
            {
                m1[i][j] = int.Parse(matriz1[k].Text);
                j++;
                if ((k + 1)% columnas1 == 0)
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
            int resul1 = (m1[0][0] * m2[0][0]) +(m1[0][01] * m2[1][0])+  (m1[0][02] * m2[2][0]);
            this.txtResul1.Text = resul1.ToString();
            int resul2 = (m1[0][0] * m2[0][1]) + (m1[0][01] * m2[01][1])+ (m1[0][02] * m2[2][1]);
            this.txtResul2.Text = resul2.ToString();
            int resul3 = (m1[0][0] * m2[0][2]) +(m1[0][1] * m2[01][2])+  (m1[0][2] * m2[02][2]);
            this.txtResul3.Text = resul3.ToString();
            int resul4 = (m1[01][00] * m2[0][0]) +(m1[01][01] * m2[01][0])+(m1[01][02] * m2[02][0]);
            this.txtResul4.Text = resul4.ToString();
            int resul5 = (m1[01][00] * m2[0][1]) +(m1[01][01] * m2[01][1]) + (m1[01][02] * m2[02][1]);
            this.txtResul5.Text = resul5.ToString();
            int resul6 = (m1[01][00] * m2[0][2]) + (m1[01][01] * m2[01][2])+ (m1[01][02] * m2[02][2]);
            this.txtResul6.Text = resul6.ToString();
            int resul7 = (m1[02][00] * m2[0][0]) + (m1[02][01] * m2[01][0]) + (m1[02][02] * m2[02][0]);
            this.txtResul7.Text = resul7.ToString();
            int resul8 = (m1[02][00] * m2[0][1]) +(m1[02][01] * m2[01][1]) +  (m1[02][02] * m2[02][1]);
            this.txtResul8.Text = resul8.ToString();
            int resul9 = (m1[02][00] * m2[0][2]) + (m1[02][01] * m2[01][2]) + (m1[02][02] * m2[02][2]);
            this.txtResul9.Text = resul9.ToString();
        }
    }
}
