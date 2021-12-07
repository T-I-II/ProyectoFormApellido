
namespace ProyectoFormApellido.matrices
{
    partial class frmJairon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textFilas1 = new System.Windows.Forms.TextBox();
            this.textColumnas1 = new System.Windows.Forms.TextBox();
            this.textFilas2 = new System.Windows.Forms.TextBox();
            this.textColumnas2 = new System.Windows.Forms.TextBox();
            this.btnMatriz1 = new System.Windows.Forms.Button();
            this.btnMatriz2 = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMatriz1);
            this.groupBox1.Controls.Add(this.textColumnas1);
            this.groupBox1.Controls.Add(this.textFilas1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz  #1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMatriz2);
            this.groupBox2.Controls.Add(this.textColumnas2);
            this.groupBox2.Controls.Add(this.textFilas2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(419, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matriz  #2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Columnas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Columnas";
            // 
            // textFilas1
            // 
            this.textFilas1.Location = new System.Drawing.Point(114, 19);
            this.textFilas1.Name = "textFilas1";
            this.textFilas1.Size = new System.Drawing.Size(100, 20);
            this.textFilas1.TabIndex = 3;
            this.textFilas1.Text = "3";
            // 
            // textColumnas1
            // 
            this.textColumnas1.Location = new System.Drawing.Point(114, 63);
            this.textColumnas1.Name = "textColumnas1";
            this.textColumnas1.Size = new System.Drawing.Size(100, 20);
            this.textColumnas1.TabIndex = 4;
            this.textColumnas1.Text = "3";
            // 
            // textFilas2
            // 
            this.textFilas2.Location = new System.Drawing.Point(151, 27);
            this.textFilas2.Name = "textFilas2";
            this.textFilas2.Size = new System.Drawing.Size(100, 20);
            this.textFilas2.TabIndex = 5;
            this.textFilas2.Text = "3";
            // 
            // textColumnas2
            // 
            this.textColumnas2.Location = new System.Drawing.Point(151, 66);
            this.textColumnas2.Name = "textColumnas2";
            this.textColumnas2.Size = new System.Drawing.Size(100, 20);
            this.textColumnas2.TabIndex = 6;
            this.textColumnas2.Text = "3";
            // 
            // btnMatriz1
            // 
            this.btnMatriz1.Location = new System.Drawing.Point(125, 138);
            this.btnMatriz1.Name = "btnMatriz1";
            this.btnMatriz1.Size = new System.Drawing.Size(75, 23);
            this.btnMatriz1.TabIndex = 5;
            this.btnMatriz1.Text = "Generar matriz";
            this.btnMatriz1.UseVisualStyleBackColor = true;
            this.btnMatriz1.Click += new System.EventHandler(this.btnMatriz1_Click);
            // 
            // btnMatriz2
            // 
            this.btnMatriz2.Location = new System.Drawing.Point(162, 138);
            this.btnMatriz2.Name = "btnMatriz2";
            this.btnMatriz2.Size = new System.Drawing.Size(75, 23);
            this.btnMatriz2.TabIndex = 7;
            this.btnMatriz2.Text = "Generar";
            this.btnMatriz2.UseVisualStyleBackColor = true;
            this.btnMatriz2.Click += new System.EventHandler(this.btnMatriz2_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(419, 298);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(100, 49);
            this.btnMultiplicar.TabIndex = 2;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // frmJairon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmJairon";
            this.Text = "frmJairon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMatriz1;
        private System.Windows.Forms.TextBox textColumnas1;
        private System.Windows.Forms.TextBox textFilas1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMatriz2;
        private System.Windows.Forms.TextBox textColumnas2;
        private System.Windows.Forms.TextBox textFilas2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMultiplicar;
    }
}