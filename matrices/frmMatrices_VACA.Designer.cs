namespace ProyectoFormApellido.matrices
{
    partial class frmMatrices_VACA
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
            this.btnCrearM1 = new System.Windows.Forms.Button();
            this.txtNColumnas1 = new System.Windows.Forms.TextBox();
            this.txtNFilas1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCrearM2 = new System.Windows.Forms.Button();
            this.txtNColumnas2 = new System.Windows.Forms.TextBox();
            this.txtNFilas2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMultiplicarMatrices = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.btnCrearM1);
            this.groupBox1.Controls.Add(this.txtNColumnas1);
            this.groupBox1.Controls.Add(this.txtNFilas1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(377, 293);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz #1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCrearM1
            // 
            this.btnCrearM1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearM1.Location = new System.Drawing.Point(77, 222);
            this.btnCrearM1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearM1.Name = "btnCrearM1";
            this.btnCrearM1.Size = new System.Drawing.Size(227, 39);
            this.btnCrearM1.TabIndex = 4;
            this.btnCrearM1.Text = "Crear matriz #1";
            this.btnCrearM1.UseVisualStyleBackColor = true;
            this.btnCrearM1.Click += new System.EventHandler(this.btnCrearM1_Click);
            // 
            // txtNColumnas1
            // 
            this.txtNColumnas1.Location = new System.Drawing.Point(193, 155);
            this.txtNColumnas1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNColumnas1.Name = "txtNColumnas1";
            this.txtNColumnas1.Size = new System.Drawing.Size(128, 29);
            this.txtNColumnas1.TabIndex = 3;
            // 
            // txtNFilas1
            // 
            this.txtNFilas1.Location = new System.Drawing.Point(193, 75);
            this.txtNFilas1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNFilas1.Name = "txtNFilas1";
            this.txtNFilas1.Size = new System.Drawing.Size(128, 29);
            this.txtNFilas1.TabIndex = 2;
            this.txtNFilas1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Columnas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filas:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.btnCrearM2);
            this.groupBox2.Controls.Add(this.txtNColumnas2);
            this.groupBox2.Controls.Add(this.txtNFilas2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(548, 48);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(377, 293);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matriz #2";
            // 
            // btnCrearM2
            // 
            this.btnCrearM2.Location = new System.Drawing.Point(73, 222);
            this.btnCrearM2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearM2.Name = "btnCrearM2";
            this.btnCrearM2.Size = new System.Drawing.Size(227, 39);
            this.btnCrearM2.TabIndex = 4;
            this.btnCrearM2.Text = "Crear matriz #2";
            this.btnCrearM2.UseVisualStyleBackColor = true;
            this.btnCrearM2.Click += new System.EventHandler(this.btnCrearM2_Click);
            // 
            // txtNColumnas2
            // 
            this.txtNColumnas2.Location = new System.Drawing.Point(193, 155);
            this.txtNColumnas2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNColumnas2.Name = "txtNColumnas2";
            this.txtNColumnas2.Size = new System.Drawing.Size(128, 29);
            this.txtNColumnas2.TabIndex = 3;
            // 
            // txtNFilas2
            // 
            this.txtNFilas2.Location = new System.Drawing.Point(193, 75);
            this.txtNFilas2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNFilas2.Name = "txtNFilas2";
            this.txtNFilas2.Size = new System.Drawing.Size(128, 29);
            this.txtNFilas2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Columnas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Filas:";
            // 
            // btnMultiplicarMatrices
            // 
            this.btnMultiplicarMatrices.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicarMatrices.Location = new System.Drawing.Point(416, 166);
            this.btnMultiplicarMatrices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMultiplicarMatrices.Name = "btnMultiplicarMatrices";
            this.btnMultiplicarMatrices.Size = new System.Drawing.Size(141, 62);
            this.btnMultiplicarMatrices.TabIndex = 4;
            this.btnMultiplicarMatrices.Text = "Multiplicar matrices";
            this.btnMultiplicarMatrices.UseVisualStyleBackColor = true;
            this.btnMultiplicarMatrices.Click += new System.EventHandler(this.btnMultiplicarMatrices_Click);
            // 
            // frmMatrices_VACA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProyectoFormApellido.Properties.Resources.fondo_formulario;
            this.ClientSize = new System.Drawing.Size(1230, 818);
            this.Controls.Add(this.btnMultiplicarMatrices);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMatrices_VACA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiplicación de matrices";
            this.Load += new System.EventHandler(this.frmMatrices_VACA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNColumnas1;
        private System.Windows.Forms.TextBox txtNFilas1;
        private System.Windows.Forms.Button btnCrearM1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCrearM2;
        private System.Windows.Forms.TextBox txtNColumnas2;
        private System.Windows.Forms.TextBox txtNFilas2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMultiplicarMatrices;
    }
}