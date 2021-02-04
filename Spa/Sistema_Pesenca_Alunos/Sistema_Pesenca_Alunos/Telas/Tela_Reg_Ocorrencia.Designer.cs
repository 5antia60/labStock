namespace Sistema_Pesenca_Alunos.Telas
{
    partial class Tela_Reg_Ocorrencia
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
            this.txbOcorrencia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbTurma = new System.Windows.Forms.TextBox();
            this.txbRA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCodProf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btRegistrarOc = new System.Windows.Forms.Button();
            this.txbCod_Aux = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbOcorrencia
            // 
            this.txbOcorrencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbOcorrencia.Location = new System.Drawing.Point(22, 197);
            this.txbOcorrencia.Multiline = true;
            this.txbOcorrencia.Name = "txbOcorrencia";
            this.txbOcorrencia.Size = new System.Drawing.Size(575, 241);
            this.txbOcorrencia.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(20, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ocorrencias:";
            // 
            // txbTurma
            // 
            this.txbTurma.Location = new System.Drawing.Point(108, 107);
            this.txbTurma.Name = "txbTurma";
            this.txbTurma.Size = new System.Drawing.Size(110, 20);
            this.txbTurma.TabIndex = 2;
            this.txbTurma.TextChanged += new System.EventHandler(this.txbTurma_TextChanged);
            // 
            // txbRA
            // 
            this.txbRA.Location = new System.Drawing.Point(108, 78);
            this.txbRA.Name = "txbRA";
            this.txbRA.Size = new System.Drawing.Size(110, 20);
            this.txbRA.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Turma:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "RA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "SPA - Registrador de Ocorrências";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbCodProf
            // 
            this.txbCodProf.Location = new System.Drawing.Point(442, 78);
            this.txbCodProf.Name = "txbCodProf";
            this.txbCodProf.Size = new System.Drawing.Size(110, 20);
            this.txbCodProf.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Código Professor:";
            // 
            // btRegistrarOc
            // 
            this.btRegistrarOc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btRegistrarOc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRegistrarOc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarOc.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btRegistrarOc.Location = new System.Drawing.Point(393, 142);
            this.btRegistrarOc.Name = "btRegistrarOc";
            this.btRegistrarOc.Size = new System.Drawing.Size(204, 49);
            this.btRegistrarOc.TabIndex = 6;
            this.btRegistrarOc.Text = "Registrar Ocorrência";
            this.btRegistrarOc.UseVisualStyleBackColor = false;
            this.btRegistrarOc.Click += new System.EventHandler(this.btRegistrarOc_Click);
            // 
            // txbCod_Aux
            // 
            this.txbCod_Aux.Location = new System.Drawing.Point(442, 107);
            this.txbCod_Aux.Name = "txbCod_Aux";
            this.txbCod_Aux.Size = new System.Drawing.Size(110, 20);
            this.txbCod_Aux.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Código Auxiliar:";
            // 
            // Tela_Reg_Ocorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.txbCod_Aux);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btRegistrarOc);
            this.Controls.Add(this.txbCodProf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbOcorrencia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbTurma);
            this.Controls.Add(this.txbRA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_Reg_Ocorrencia";
            this.ShowIcon = false;
            this.Text = "SPA - Sistema de Presença Alunos";
            this.Load += new System.EventHandler(this.Tela_Reg_Ocorrencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbOcorrencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbTurma;
        private System.Windows.Forms.TextBox txbRA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCodProf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btRegistrarOc;
        private System.Windows.Forms.TextBox txbCod_Aux;
        private System.Windows.Forms.Label label5;
    }
}