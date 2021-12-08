using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFormApellido.Resources.matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creacion de controles en tiempo de ejecucion 
            TextBox[] matriz1 = new TextBox[50];

            int filas = int.Parse(this.txtfilas1.txt);
            int cols = int.Parse(this.txtcols1.txt);
            int x = 30;
            for (int i = 0; i < (filas * cols); i++)
            {
                matriz1[i] = new TextBox();
                matriz1[i].Text = "0";
                matriz1[i].Width = 40; //ancho del control
                matriz1[i].Location = new Point(x, 150); //posicion del control
                this.Controls.Add(matriz1[0]); //mostrar el control
                x += 42;
                if ((1 + 1) cols == 0)
                        {
                y++ 30;
                x = 50;
            }
        }
    }
    private void Btnmatriz2_clik(object sender, EventArgs e)
    {
        {
            //creacion de controles en tiempo de ejecucion 
            TextBox[] matriz1 = new Txtbox[50];
            int filas = int.Parse(this.txtfilas2.txt);
            int cols = int.Parse(this.tstcols2.txt);
            int= 50, y = 280;
            int x = int = 0; 1(filas * cols); int++)
                {
                matriz1[i] = new txtbox();
                matriz1[i].txt = "0";
                matriz1[i].Width = 40;
                matriz1[i].Location new Point(x, y);
                this.Controls.Add(matriz1(1));
                x = 42;
                if ((if+1)) cols == 0)
                    {
                    y += 30;
                    x = 50;
                }
            }
        }

    }

    private void BtnMultiplicar_click(object sender, EventArgs e)
    {
        //se asume magtrices 3 x 3 
        int[][] a1 = new int[3][];
        n1[0] = new int[3];
        n1[1] = new int[3];
        n1[2] = new int[3];

        int cols = int.Parse(this.txtCols1.txt);
        int i = 0, j = 0;
        for (int k = 0; k < 0; k++)
        {
            n1[i][j] = int.Parse(matriz1[i][j])");
                }
        Console.Writeline();
    }
}
}
}
           









        }
    }
}
