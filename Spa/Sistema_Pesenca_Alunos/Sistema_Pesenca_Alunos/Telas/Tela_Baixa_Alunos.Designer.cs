namespace Sistema_Pesenca_Alunos.Telas
{
    partial class Tela_Baixa_Alunos
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
            this.btInserir = new System.Windows.Forms.Button();
            this.txbRA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Historico = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.DTPDataFim = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DTPDataInicio = new System.Windows.Forms.DateTimePicker();
            this.btProcurar = new System.Windows.Forms.Button();
            this.txbhora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbminutos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Historico)).BeginInit();
            this.SuspendLayout();
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btInserir.Location = new System.Drawing.Point(609, 392);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(179, 65);
            this.btInserir.TabIndex = 67;
            this.btInserir.Text = "Registrar Saida";
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // txbRA
            // 
            this.txbRA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txbRA.Location = new System.Drawing.Point(50, 20);
            this.txbRA.Name = "txbRA";
            this.txbRA.Size = new System.Drawing.Size(110, 25);
            this.txbRA.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "RA:";
            // 
            // Historico
            // 
            this.Historico.AllowUserToAddRows = false;
            this.Historico.AllowUserToDeleteRows = false;
            this.Historico.AllowUserToResizeColumns = false;
            this.Historico.AllowUserToResizeRows = false;
            this.Historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Historico.Location = new System.Drawing.Point(12, 57);
            this.Historico.Name = "Historico";
            this.Historico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Historico.Size = new System.Drawing.Size(776, 323);
            this.Historico.TabIndex = 72;
            this.Historico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Historico_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(359, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.TabIndex = 79;
            this.label7.Text = "Até:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTPDataFim
            // 
            this.DTPDataFim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.DTPDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDataFim.Location = new System.Drawing.Point(401, 22);
            this.DTPDataFim.Name = "DTPDataFim";
            this.DTPDataFim.Size = new System.Drawing.Size(110, 25);
            this.DTPDataFim.TabIndex = 78;
            this.DTPDataFim.Value = new System.DateTime(2020, 9, 16, 23, 59, 59, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(179, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 77;
            this.label6.Text = "De:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTPDataInicio
            // 
            this.DTPDataInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.DTPDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDataInicio.Location = new System.Drawing.Point(216, 20);
            this.DTPDataInicio.Name = "DTPDataInicio";
            this.DTPDataInicio.Size = new System.Drawing.Size(110, 25);
            this.DTPDataInicio.TabIndex = 76;
            this.DTPDataInicio.Value = new System.DateTime(2020, 9, 16, 0, 0, 0, 0);
            // 
            // btProcurar
            // 
            this.btProcurar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcurar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btProcurar.Location = new System.Drawing.Point(570, 17);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(144, 34);
            this.btProcurar.TabIndex = 80;
            this.btProcurar.Text = "Procurar";
            this.btProcurar.UseVisualStyleBackColor = false;
            this.btProcurar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbhora
            // 
            this.txbhora.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txbhora.Location = new System.Drawing.Point(65, 422);
            this.txbhora.Name = "txbhora";
            this.txbhora.Size = new System.Drawing.Size(110, 25);
            this.txbhora.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 81;
            this.label1.Text = "Hora:";
            // 
            // txbminutos
            // 
            this.txbminutos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txbminutos.Location = new System.Drawing.Point(253, 422);
            this.txbminutos.Name = "txbminutos";
            this.txbminutos.Size = new System.Drawing.Size(110, 25);
            this.txbminutos.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 83;
            this.label3.Text = "Minutos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 19);
            this.label4.TabIndex = 85;
            this.label4.Text = "Horario de Entrada / Saida:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(424, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 65);
            this.button1.TabIndex = 86;
            this.button1.Text = "Registrar Entrada";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Tela_Baixa_Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbminutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbhora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btProcurar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DTPDataFim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTPDataInicio);
            this.Controls.Add(this.Historico);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.txbRA);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_Baixa_Alunos";
            this.Text = "Tela_Baixa_Alunos";
            this.Load += new System.EventHandler(this.Tela_Baixa_Alunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Historico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.TextBox txbRA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Historico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTPDataFim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTPDataInicio;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.TextBox txbhora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbminutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}