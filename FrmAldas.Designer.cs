
namespace ProyectoFormApellido
{
    partial class FrmAldas
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
            this.BtnPresentacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPresentacion
            // 
            this.BtnPresentacion.Location = new System.Drawing.Point(275, 111);
            this.BtnPresentacion.Name = "BtnPresentacion";
            this.BtnPresentacion.Size = new System.Drawing.Size(146, 57);
            this.BtnPresentacion.TabIndex = 0;
            this.BtnPresentacion.Text = "Presentacion-Victor ";
            this.BtnPresentacion.UseVisualStyleBackColor = true;
            this.BtnPresentacion.Click += new System.EventHandler(this.BtnPresentacion_Click);
            // 
            // FrmAldas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPresentacion);
            this.Name = "FrmAldas";
            this.Text = "FrmAldas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPresentacion;
    }
}