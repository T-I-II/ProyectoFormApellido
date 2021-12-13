
namespace ProyectoFormApellido.Matrices
{
    partial class frmCervantes
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
            this.btnMatriz1 = new System.Windows.Forms.Button();
            this.txtcolumna1 = new System.Windows.Forms.TextBox();
            this.txtfila1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMatriz2 = new System.Windows.Forms.Button();
            this.txtcolumna2 = new System.Windows.Forms.TextBox();
            this.txtfila2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMultiplicador = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMatriz1);
            this.groupBox1.Controls.Add(this.txtcolumna1);
            this.groupBox1.Controls.Add(this.txtfila1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz #1";
            // 
            // btnMatriz1
            // 
            this.btnMatriz1.Location = new System.Drawing.Point(103, 113);
            this.btnMatriz1.Name = "btnMatriz1";
            this.btnMatriz1.Size = new System.Drawing.Size(100, 44);
            this.btnMatriz1.TabIndex = 4;
            this.btnMatriz1.Text = "Calcular ";
            this.btnMatriz1.UseVisualStyleBackColor = true;
            this.btnMatriz1.Click += new System.EventHandler(this.btnMatriz1_Click);
            // 
            // txtcolumna1
            // 
            this.txtcolumna1.Location = new System.Drawing.Point(103, 80);
            this.txtcolumna1.Name = "txtcolumna1";
            this.txtcolumna1.Size = new System.Drawing.Size(100, 20);
            this.txtcolumna1.TabIndex = 3;
            // 
            // txtfila1
            // 
            this.txtfila1.Location = new System.Drawing.Point(103, 34);
            this.txtfila1.Name = "txtfila1";
            this.txtfila1.Size = new System.Drawing.Size(100, 20);
            this.txtfila1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columnas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "filas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMatriz2);
            this.groupBox2.Controls.Add(this.txtcolumna2);
            this.groupBox2.Controls.Add(this.txtfila2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(387, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matriz #2";
            // 
            // btnMatriz2
            // 
            this.btnMatriz2.Location = new System.Drawing.Point(143, 113);
            this.btnMatriz2.Name = "btnMatriz2";
            this.btnMatriz2.Size = new System.Drawing.Size(109, 36);
            this.btnMatriz2.TabIndex = 4;
            this.btnMatriz2.Text = "Calcular";
            this.btnMatriz2.UseVisualStyleBackColor = true;
            this.btnMatriz2.Click += new System.EventHandler(this.btnMatriz2_Click);
            // 
            // txtcolumna2
            // 
            this.txtcolumna2.Location = new System.Drawing.Point(152, 73);
            this.txtcolumna2.Name = "txtcolumna2";
            this.txtcolumna2.Size = new System.Drawing.Size(100, 20);
            this.txtcolumna2.TabIndex = 3;
            // 
            // txtfila2
            // 
            this.txtfila2.Location = new System.Drawing.Point(152, 32);
            this.txtfila2.Name = "txtfila2";
            this.txtfila2.Size = new System.Drawing.Size(100, 20);
            this.txtfila2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Columnas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Filas";
            // 
            // btnMultiplicador
            // 
            this.btnMultiplicador.Location = new System.Drawing.Point(301, 192);
            this.btnMultiplicador.Name = "btnMultiplicador";
            this.btnMultiplicador.Size = new System.Drawing.Size(134, 59);
            this.btnMultiplicador.TabIndex = 2;
            this.btnMultiplicador.Text = "Multiplicar Matrices";
            this.btnMultiplicador.UseVisualStyleBackColor = true;
            this.btnMultiplicador.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resultado
            // 
            this.Resultado.AllowUserToOrderColumns = true;
            this.Resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Resultado.Location = new System.Drawing.Point(576, 315);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(212, 123);
            this.Resultado.TabIndex = 3;
            // 
            // frmCervantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.btnMultiplicador);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCervantes";
            this.Text = "Multilicacion de matrices";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMatriz1;
        private System.Windows.Forms.TextBox txtcolumna1;
        private System.Windows.Forms.TextBox txtfila1;
        private System.Windows.Forms.Button btnMatriz2;
        private System.Windows.Forms.TextBox txtcolumna2;
        private System.Windows.Forms.TextBox txtfila2;
        private System.Windows.Forms.Button btnMultiplicador;
        private System.Windows.Forms.DataGridView Resultado;
    }
}