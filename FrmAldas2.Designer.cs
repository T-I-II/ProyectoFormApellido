
namespace ProyectoFormApellido
{
    partial class FrmAldas2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtFilas = new System.Windows.Forms.Label();
            this.TxtCols = new System.Windows.Forms.Label();
            this.TxtFilas1 = new System.Windows.Forms.TextBox();
            this.TxtCols1 = new System.Windows.Forms.TextBox();
            this.TxtFilas2 = new System.Windows.Forms.TextBox();
            this.TxtCols2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnMatriz1 = new System.Windows.Forms.Button();
            this.BtnMatriz2 = new System.Windows.Forms.Button();
            this.BtnMultiplicar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtCols1);
            this.groupBox1.Controls.Add(this.TxtFilas1);
            this.groupBox1.Controls.Add(this.TxtCols);
            this.groupBox1.Controls.Add(this.TxtFilas);
            this.groupBox1.Location = new System.Drawing.Point(18, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz#1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtCols2);
            this.groupBox2.Controls.Add(this.TxtFilas2);
            this.groupBox2.Location = new System.Drawing.Point(436, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 169);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matriz#2";
            // 
            // TxtFilas
            // 
            this.TxtFilas.AutoSize = true;
            this.TxtFilas.Location = new System.Drawing.Point(6, 39);
            this.TxtFilas.Name = "TxtFilas";
            this.TxtFilas.Size = new System.Drawing.Size(31, 13);
            this.TxtFilas.TabIndex = 3;
            this.TxtFilas.Text = "Filas:";
            // 
            // TxtCols
            // 
            this.TxtCols.AutoSize = true;
            this.TxtCols.Location = new System.Drawing.Point(6, 69);
            this.TxtCols.Name = "TxtCols";
            this.TxtCols.Size = new System.Drawing.Size(56, 13);
            this.TxtCols.TabIndex = 3;
            this.TxtCols.Text = "Columnas:";
            // 
            // TxtFilas1
            // 
            this.TxtFilas1.Location = new System.Drawing.Point(106, 39);
            this.TxtFilas1.Name = "TxtFilas1";
            this.TxtFilas1.Size = new System.Drawing.Size(100, 20);
            this.TxtFilas1.TabIndex = 3;
            this.TxtFilas1.Text = "3";
            // 
            // TxtCols1
            // 
            this.TxtCols1.Location = new System.Drawing.Point(106, 69);
            this.TxtCols1.Name = "TxtCols1";
            this.TxtCols1.Size = new System.Drawing.Size(100, 20);
            this.TxtCols1.TabIndex = 3;
            this.TxtCols1.Text = "3";
            // 
            // TxtFilas2
            // 
            this.TxtFilas2.Location = new System.Drawing.Point(119, 39);
            this.TxtFilas2.Name = "TxtFilas2";
            this.TxtFilas2.Size = new System.Drawing.Size(100, 20);
            this.TxtFilas2.TabIndex = 3;
            this.TxtFilas2.Text = "3";
            // 
            // TxtCols2
            // 
            this.TxtCols2.Location = new System.Drawing.Point(119, 69);
            this.TxtCols2.Name = "TxtCols2";
            this.TxtCols2.Size = new System.Drawing.Size(100, 20);
            this.TxtCols2.TabIndex = 4;
            this.TxtCols2.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Columnas:";
            // 
            // BtnMatriz1
            // 
            this.BtnMatriz1.Location = new System.Drawing.Point(59, 143);
            this.BtnMatriz1.Name = "BtnMatriz1";
            this.BtnMatriz1.Size = new System.Drawing.Size(119, 44);
            this.BtnMatriz1.TabIndex = 3;
            this.BtnMatriz1.Text = "Crear Matriz 1";
            this.BtnMatriz1.UseVisualStyleBackColor = true;
            this.BtnMatriz1.Click += new System.EventHandler(this.BtmMatriz1_Click);
            // 
            // BtnMatriz2
            // 
            this.BtnMatriz2.Location = new System.Drawing.Point(447, 150);
            this.BtnMatriz2.Name = "BtnMatriz2";
            this.BtnMatriz2.Size = new System.Drawing.Size(214, 37);
            this.BtnMatriz2.TabIndex = 7;
            this.BtnMatriz2.Text = "Crear Matriz 2";
            this.BtnMatriz2.UseVisualStyleBackColor = true;
            this.BtnMatriz2.Click += new System.EventHandler(this.BtnMatriz2_Click);
            // 
            // BtnMultiplicar
            // 
            this.BtnMultiplicar.Location = new System.Drawing.Point(239, 224);
            this.BtnMultiplicar.Name = "BtnMultiplicar";
            this.BtnMultiplicar.Size = new System.Drawing.Size(182, 61);
            this.BtnMultiplicar.TabIndex = 8;
            this.BtnMultiplicar.Text = "Multiplicar Matrices";
            this.BtnMultiplicar.UseVisualStyleBackColor = true;
            this.BtnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicar_Click);
            // 
            // FrmAldas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMultiplicar);
            this.Controls.Add(this.BtnMatriz2);
            this.Controls.Add(this.BtnMatriz1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmAldas2";
            this.Text = "Multiplicacion de Matrices";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtCols1;
        private System.Windows.Forms.TextBox TxtFilas1;
        private System.Windows.Forms.Label TxtCols;
        private System.Windows.Forms.Label TxtFilas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCols2;
        private System.Windows.Forms.TextBox TxtFilas2;
        private System.Windows.Forms.Button BtnMatriz1;
        private System.Windows.Forms.Button BtnMatriz2;
        private System.Windows.Forms.Button BtnMultiplicar;
    }
}