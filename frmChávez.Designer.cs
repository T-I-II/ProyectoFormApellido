
namespace ProyectoFormApellido
{
    partial class frmChávez
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
            this.btnSALUDAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSALUDAR
            // 
            this.btnSALUDAR.Location = new System.Drawing.Point(268, 127);
            this.btnSALUDAR.Name = "btnSALUDAR";
            this.btnSALUDAR.Size = new System.Drawing.Size(304, 119);
            this.btnSALUDAR.TabIndex = 0;
            this.btnSALUDAR.Text = "SALUDAR";
            this.btnSALUDAR.UseVisualStyleBackColor = true;
            this.btnSALUDAR.Click += new System.EventHandler(this.btnSALUDAR_Click);
            // 
            // frmChávez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSALUDAR);
            this.Name = "frmChávez";
            this.Text = "frmChávez";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSALUDAR;
    }
}