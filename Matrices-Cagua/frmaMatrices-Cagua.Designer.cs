
namespace ProyectoFormApellido.Matrices_Cagua
{
    partial class frmaMatrices_Cagua
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
            this.groupBox1.Controls.Add(this.txtCols1);
            this.groupBox1.Controls.Add(this.txtFilas1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz#2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMatriz2);
            this.groupBox2.Controls.Add(this.txtCols2);
            this.groupBox2.Controls.Add(this.txtFilas2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(411, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matriz#2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Columnas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Filas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Columnas";
            // 
            // txtFilas1
            // 
            this.txtFilas1.Location = new System.Drawing.Point(104, 31);
            this.txtFilas1.Name = "txtFilas1";
            this.txtFilas1.Size = new System.Drawing.Size(100, 20);
            this.txtFilas1.TabIndex = 1;
            // 
            // txtCols1
            // 
            this.txtCols1.Location = new System.Drawing.Point(104, 90);
            this.txtCols1.Name = "txtCols1";
            this.txtCols1.Size = new System.Drawing.Size(100, 20);
            this.txtCols1.TabIndex = 2;
            // 
            // txtFilas2
            // 
            this.txtFilas2.Location = new System.Drawing.Point(94, 20);
            this.txtFilas2.Name = "txtFilas2";
            this.txtFilas2.Size = new System.Drawing.Size(100, 20);
            this.txtFilas2.TabIndex = 2;
            // 
            // txtCols2
            // 
            this.txtCols2.Location = new System.Drawing.Point(94, 70);
            this.txtCols2.Name = "txtCols2";
            this.txtCols2.Size = new System.Drawing.Size(100, 20);
            this.txtCols2.TabIndex = 3;
            // 
            // btnMatriz1
            // 
            this.btnMatriz1.Location = new System.Drawing.Point(44, 146);
            this.btnMatriz1.Name = "btnMatriz1";
            this.btnMatriz1.Size = new System.Drawing.Size(129, 33);
            this.btnMatriz1.TabIndex = 3;
            this.btnMatriz1.Text = "Crear Matriz #1";
            this.btnMatriz1.UseVisualStyleBackColor = true;
            this.btnMatriz1.Click += new System.EventHandler(this.btnMatriz1_Click);
            // 
            // btnMatriz2
            // 
            this.btnMatriz2.Location = new System.Drawing.Point(49, 146);
            this.btnMatriz2.Name = "btnMatriz2";
            this.btnMatriz2.Size = new System.Drawing.Size(145, 33);
            this.btnMatriz2.TabIndex = 4;
            this.btnMatriz2.Text = "Crear Matriz #2";
            this.btnMatriz2.UseVisualStyleBackColor = true;
            this.btnMatriz2.Click += new System.EventHandler(this.btnMatriz2_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(260, 260);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(165, 46);
            this.btnMultiplicar.TabIndex = 2;
            this.btnMultiplicar.Text = "Multiplicar matrices";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // frmaMatrices_Cagua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 547);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmaMatrices_Cagua";
            this.Text = "frmaMatrices_Cagua";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMatriz1;
        private System.Windows.Forms.TextBox txtCols1;
        private System.Windows.Forms.TextBox txtFilas1;
        private System.Windows.Forms.Button btnMatriz2;
        private System.Windows.Forms.TextBox txtCols2;
        private System.Windows.Forms.TextBox txtFilas2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMultiplicar;
    }
}