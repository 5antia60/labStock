namespace LabEstoque.Apresentação
{
    partial class MostrarFoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarFoto));
            this.ImgAmpliada = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAmpliada)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgAmpliada
            // 
            this.ImgAmpliada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgAmpliada.Location = new System.Drawing.Point(12, 12);
            this.ImgAmpliada.Name = "ImgAmpliada";
            this.ImgAmpliada.Size = new System.Drawing.Size(1140, 728);
            this.ImgAmpliada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgAmpliada.TabIndex = 0;
            this.ImgAmpliada.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(1051, 746);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(101, 38);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // MostrarFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 794);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.ImgAmpliada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MostrarFoto";
            this.Text = "Mostrar Foto";
            this.Load += new System.EventHandler(this.MostrarFoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgAmpliada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgAmpliada;
        private System.Windows.Forms.Button btnFechar;
    }
}