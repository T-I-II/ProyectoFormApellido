
namespace ProyectoFormApellido
{
    partial class FrmJunco
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
            this.BtnSaludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSaludar
            // 
            this.BtnSaludar.Location = new System.Drawing.Point(267, 168);
            this.BtnSaludar.Name = "BtnSaludar";
            this.BtnSaludar.Size = new System.Drawing.Size(114, 58);
            this.BtnSaludar.TabIndex = 0;
            this.BtnSaludar.Text = "SALUDAR";
            this.BtnSaludar.UseVisualStyleBackColor = true;
            this.BtnSaludar.Click += new System.EventHandler(this.BtnSaludar_Click);
            // 
            // FrmJunco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSaludar);
            this.Name = "FrmJunco";
            this.Text = "FrmJunco";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSaludar;
    }
}