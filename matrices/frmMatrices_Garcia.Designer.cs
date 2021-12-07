
namespace ProyectoFormApellido.matrices
{
    partial class frmMatrices_Garcia
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
            this.txtFilas1 = new System.Windows.Forms.TextBox();
            this.txtCols1 = new System.Windows.Forms.TextBox();
            this.txtFilas2 = new System.Windows.Forms.TextBox();
            this.txtCols2 = new System.Windows.Forms.TextBox();
            this.btnMatriz2 = new System.Windows.Forms.Button();
            this.btnMatriz1 = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMatriz1);
            this.groupBox1.Controls.Add(this.txtCols1);
            this.groupBox1.Controls.Add(this.txtFilas1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(64, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz #1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMatriz2);
            this.groupBox2.Controls.Add(this.txtCols2);
            this.groupBox2.Controls.Add(this.txtFilas2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(430, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matriz #2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columnas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Columnas";
            // 
            // txtFilas1
            // 
            this.txtFilas1.Location = new System.Drawing.Point(110, 43);
            this.txtFilas1.Name = "txtFilas1";
            this.txtFilas1.Size = new System.Drawing.Size(94, 20);
            this.txtFilas1.TabIndex = 4;
            // 
            // txtCols1
            // 
            this.txtCols1.Location = new System.Drawing.Point(110, 93);
            this.txtCols1.Name = "txtCols1";
            this.txtCols1.Size = new System.Drawing.Size(94, 20);
            this.txtCols1.TabIndex = 5;
            // 
            // txtFilas2
            // 
            this.txtFilas2.Location = new System.Drawing.Point(134, 40);
            this.txtFilas2.Name = "txtFilas2";
            this.txtFilas2.Size = new System.Drawing.Size(94, 20);
            this.txtFilas2.TabIndex = 6;
            // 
            // txtCols2
            // 
            this.txtCols2.Location = new System.Drawing.Point(134, 93);
            this.txtCols2.Name = "txtCols2";
            this.txtCols2.Size = new System.Drawing.Size(94, 20);
            this.txtCols2.TabIndex = 7;
            // 
            // btnMatriz2
            // 
            this.btnMatriz2.Location = new System.Drawing.Point(31, 132);
            this.btnMatriz2.Name = "btnMatriz2";
            this.btnMatriz2.Size = new System.Drawing.Size(197, 34);
            this.btnMatriz2.TabIndex = 8;
            this.btnMatriz2.Text = "Crear Matriz #2";
            this.btnMatriz2.UseVisualStyleBackColor = true;
            this.btnMatriz2.Click += new System.EventHandler(this.btnMatriz2_Click);
            // 
            // btnMatriz1
            // 
            this.btnMatriz1.Location = new System.Drawing.Point(24, 135);
            this.btnMatriz1.Name = "btnMatriz1";
            this.btnMatriz1.Size = new System.Drawing.Size(197, 34);
            this.btnMatriz1.TabIndex = 9;
            this.btnMatriz1.Text = "Crear matriz #1";
            this.btnMatriz1.UseVisualStyleBackColor = true;
            this.btnMatriz1.Click += new System.EventHandler(this.btnMatriz1_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(297, 239);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(133, 45);
            this.btnMultiplicar.TabIndex = 2;
            this.btnMultiplicar.Text = "Multiplicar Matrices";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // frmMatrices_Garcia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMatrices_Garcia";
            this.Text = "frmMatrices_Garcia";
            this.Load += new System.EventHandler(this.frmMatrices_Garcia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMatriz1;
        private System.Windows.Forms.TextBox txtCols1;
        private System.Windows.Forms.TextBox txtFilas1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMatriz2;
        private System.Windows.Forms.TextBox txtCols2;
        private System.Windows.Forms.TextBox txtFilas2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMultiplicar;
    }
}