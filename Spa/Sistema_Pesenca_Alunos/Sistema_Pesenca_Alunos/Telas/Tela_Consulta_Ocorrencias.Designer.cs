namespace Sistema_Pesenca_Alunos.Telas
{
    partial class Tela_Consulta_Ocorrencias
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
            this.label3 = new System.Windows.Forms.Label();
            this.txbCol = new System.Windows.Forms.ComboBox();
            this.txbPesq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Historico = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Historico)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbCol);
            this.groupBox1.Controls.Add(this.txbPesq);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 100);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procurar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Linha:";
            // 
            // txbCol
            // 
            this.txbCol.FormattingEnabled = true;
            this.txbCol.Items.AddRange(new object[] {
            "Cod_Aluno",
            "Cod_Turma",
            "Cod_Prof",
            "Cod_Aux",
            "Ocorrencia"});
            this.txbCol.Location = new System.Drawing.Point(23, 45);
            this.txbCol.Name = "txbCol";
            this.txbCol.Size = new System.Drawing.Size(112, 26);
            this.txbCol.TabIndex = 10;
            this.txbCol.Text = "Cod_Aluno";
            // 
            // txbPesq
            // 
            this.txbPesq.Location = new System.Drawing.Point(211, 47);
            this.txbPesq.Name = "txbPesq";
            this.txbPesq.Size = new System.Drawing.Size(311, 24);
            this.txbPesq.TabIndex = 9;
            this.txbPesq.TextChanged += new System.EventHandler(this.txbPesq_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Coluna:";
            // 
            // Historico
            // 
            this.Historico.AllowUserToAddRows = false;
            this.Historico.AllowUserToDeleteRows = false;
            this.Historico.AllowUserToResizeColumns = false;
            this.Historico.AllowUserToResizeRows = false;
            this.Historico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Historico.Location = new System.Drawing.Point(12, 178);
            this.Historico.Name = "Historico";
            this.Historico.ReadOnly = true;
            this.Historico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Historico.Size = new System.Drawing.Size(1024, 332);
            this.Historico.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 41);
            this.label1.TabIndex = 26;
            this.label1.Text = "SPA - Consulta de Ocorrencias";
            // 
            // Tela_Consulta_Ocorrencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Historico);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_Consulta_Ocorrencias";
            this.ShowIcon = false;
            this.Text = "SPA - Sistema de Presença Alunos";
            this.Load += new System.EventHandler(this.Tela_Consulta_Ocorrencias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Historico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txbCol;
        private System.Windows.Forms.TextBox txbPesq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Historico;
        private System.Windows.Forms.Label label1;
    }
}