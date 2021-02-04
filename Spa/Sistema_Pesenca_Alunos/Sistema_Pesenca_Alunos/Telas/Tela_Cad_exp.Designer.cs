namespace Sistema_Pesenca_Alunos.Telas
{
    partial class Tela_Cad_exp
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbExperimento = new System.Windows.Forms.TextBox();
            this.txbDiscilpina = new System.Windows.Forms.TextBox();
            this.btCadExp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMaterial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 51;
            this.label5.Text = "Experimento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Disciplina:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbExperimento
            // 
            this.txbExperimento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbExperimento.Location = new System.Drawing.Point(133, 296);
            this.txbExperimento.Name = "txbExperimento";
            this.txbExperimento.Size = new System.Drawing.Size(424, 25);
            this.txbExperimento.TabIndex = 52;
            // 
            // txbDiscilpina
            // 
            this.txbDiscilpina.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiscilpina.Location = new System.Drawing.Point(133, 340);
            this.txbDiscilpina.Name = "txbDiscilpina";
            this.txbDiscilpina.Size = new System.Drawing.Size(424, 25);
            this.txbDiscilpina.TabIndex = 53;
            // 
            // btCadExp
            // 
            this.btCadExp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCadExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCadExp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btCadExp.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btCadExp.Location = new System.Drawing.Point(577, 296);
            this.btCadExp.Name = "btCadExp";
            this.btCadExp.Size = new System.Drawing.Size(174, 69);
            this.btCadExp.TabIndex = 54;
            this.btCadExp.Text = "Cadastrar Experimento";
            this.btCadExp.UseVisualStyleBackColor = false;
            this.btCadExp.Click += new System.EventHandler(this.btCadExp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 41);
            this.label1.TabIndex = 55;
            this.label1.Text = "SPA - Cadastro de Experimentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 38);
            this.label2.TabIndex = 56;
            this.label2.Text = "Materiais\r\nnecessários:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbMaterial
            // 
            this.txbMaterial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaterial.Location = new System.Drawing.Point(133, 97);
            this.txbMaterial.Multiline = true;
            this.txbMaterial.Name = "txbMaterial";
            this.txbMaterial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbMaterial.Size = new System.Drawing.Size(618, 183);
            this.txbMaterial.TabIndex = 57;
            // 
            // Tela_Cad_exp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(766, 378);
            this.Controls.Add(this.txbMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCadExp);
            this.Controls.Add(this.txbDiscilpina);
            this.Controls.Add(this.txbExperimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_Cad_exp";
            this.ShowIcon = false;
            this.Text = "SPA - Sistema de Presença Alunos";
            this.Load += new System.EventHandler(this.Tela_Cad_exp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbExperimento;
        private System.Windows.Forms.TextBox txbDiscilpina;
        private System.Windows.Forms.Button btCadExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMaterial;
    }
}