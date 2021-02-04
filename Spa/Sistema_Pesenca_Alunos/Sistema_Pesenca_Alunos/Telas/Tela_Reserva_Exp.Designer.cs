namespace Sistema_Pesenca_Alunos.Telas
{
    partial class Tela_Reserva_Exp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.cbDisciplina = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbExperimento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbNomeProf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPredio = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mtbSala = new System.Windows.Forms.MaskedTextBox();
            this.txbData = new System.Windows.Forms.MaskedTextBox();
            this.txbHora = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btInserir.Location = new System.Drawing.Point(192, 371);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(204, 78);
            this.btInserir.TabIndex = 39;
            this.btInserir.Text = "Fazer Reserva";
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // txbRA
            // 
            this.txbRA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txbRA.Location = new System.Drawing.Point(120, 114);
            this.txbRA.Name = "txbRA";
            this.txbRA.Size = new System.Drawing.Size(110, 25);
            this.txbRA.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "RA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 41);
            this.label1.TabIndex = 24;
            this.label1.Text = "SPA - Reserva de Experimentos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Semestre Reposição:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbSemestre
            // 
            this.cbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemestre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Items.AddRange(new object[] {
            "1° Semestre",
            "2° Semestre",
            "3° Semestre",
            "4° Semestre",
            "5° Semestre",
            "6° Semestre",
            "7° Semestre",
            "8° Semestre",
            "9° Semestre",
            "10° Semestre"});
            this.cbSemestre.Location = new System.Drawing.Point(402, 114);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(121, 25);
            this.cbSemestre.TabIndex = 42;
            this.cbSemestre.SelectedIndexChanged += new System.EventHandler(this.cbSemestre_SelectedIndexChanged);
            // 
            // cbDisciplina
            // 
            this.cbDisciplina.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cbDisciplina.FormattingEnabled = true;
            this.cbDisciplina.Location = new System.Drawing.Point(120, 183);
            this.cbDisciplina.Name = "cbDisciplina";
            this.cbDisciplina.Size = new System.Drawing.Size(403, 25);
            this.cbDisciplina.TabIndex = 44;
            this.cbDisciplina.Text = "Selecione";
            this.cbDisciplina.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Disciplina:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbExperimento
            // 
            this.cbExperimento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cbExperimento.FormattingEnabled = true;
            this.cbExperimento.Location = new System.Drawing.Point(120, 216);
            this.cbExperimento.Name = "cbExperimento";
            this.cbExperimento.Size = new System.Drawing.Size(403, 25);
            this.cbExperimento.TabIndex = 46;
            this.cbExperimento.Text = "Selecione";
            this.cbExperimento.SelectedIndexChanged += new System.EventHandler(this.cbExperimento_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Experimento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "Data:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 51;
            this.label8.Text = "Nome do Professor";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbNomeProf
            // 
            this.txbNomeProf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txbNomeProf.Location = new System.Drawing.Point(162, 247);
            this.txbNomeProf.Name = "txbNomeProf";
            this.txbNomeProf.Size = new System.Drawing.Size(361, 25);
            this.txbNomeProf.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 50;
            this.label7.Text = "Hora:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCurso
            // 
            this.cbCurso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(120, 152);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(403, 25);
            this.cbCurso.TabIndex = 54;
            this.cbCurso.Text = "Selecione";
            this.cbCurso.SelectedIndexChanged += new System.EventHandler(this.cbCurso_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 53;
            this.label9.Text = "Curso:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(98, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 56;
            this.label10.Text = "Predio:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPredio
            // 
            this.cbPredio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cbPredio.FormattingEnabled = true;
            this.cbPredio.Items.AddRange(new object[] {
            "Selecione",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L"});
            this.cbPredio.Location = new System.Drawing.Point(162, 309);
            this.cbPredio.Name = "cbPredio";
            this.cbPredio.Size = new System.Drawing.Size(110, 25);
            this.cbPredio.TabIndex = 55;
            this.cbPredio.Text = "Selecione";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(296, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 19);
            this.label11.TabIndex = 58;
            this.label11.Text = "Sala:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // mtbSala
            // 
            this.mtbSala.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.mtbSala.Location = new System.Drawing.Point(343, 309);
            this.mtbSala.Mask = "00";
            this.mtbSala.Name = "mtbSala";
            this.mtbSala.Size = new System.Drawing.Size(53, 25);
            this.mtbSala.TabIndex = 59;
            this.mtbSala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbSala.ValidatingType = typeof(int);
            // 
            // txbData
            // 
            this.txbData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbData.Location = new System.Drawing.Point(162, 279);
            this.txbData.Mask = "00/00/0000";
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(79, 25);
            this.txbData.TabIndex = 60;
            this.txbData.ValidatingType = typeof(System.DateTime);
            // 
            // txbHora
            // 
            this.txbHora.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHora.Location = new System.Drawing.Point(343, 278);
            this.txbHora.Mask = "00:00";
            this.txbHora.Name = "txbHora";
            this.txbHora.Size = new System.Drawing.Size(53, 25);
            this.txbHora.TabIndex = 61;
            this.txbHora.ValidatingType = typeof(System.DateTime);
            // 
            // Tela_Reserva_Exp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(575, 463);
            this.Controls.Add(this.txbHora);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.mtbSala);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbPredio);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbNomeProf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbExperimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDisciplina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSemestre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.txbRA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_Reserva_Exp";
            this.ShowIcon = false;
            this.Text = "SPA - Sistema de Presença Alunos";
            this.Load += new System.EventHandler(this.Tela_Reserva_Exp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.TextBox txbRA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.ComboBox cbDisciplina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbExperimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbNomeProf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbPredio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtbSala;
        private System.Windows.Forms.MaskedTextBox txbData;
        private System.Windows.Forms.MaskedTextBox txbHora;
    }
}