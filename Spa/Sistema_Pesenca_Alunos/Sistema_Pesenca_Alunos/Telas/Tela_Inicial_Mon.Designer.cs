namespace Sistema_Pesenca_Alunos
{
    partial class Tela_Inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCodProf = new System.Windows.Forms.TextBox();
            this.txbTempProf = new System.Windows.Forms.TextBox();
            this.txbCodAux = new System.Windows.Forms.TextBox();
            this.txbTempAux = new System.Windows.Forms.TextBox();
            this.txbRA = new System.Windows.Forms.TextBox();
            this.txbTurma = new System.Windows.Forms.TextBox();
            this.txbTempAluno = new System.Windows.Forms.TextBox();
            this.btInserir = new System.Windows.Forms.Button();
            this.txbObservacao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Tsmi_Ocorrencia = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Consulta = new System.Windows.Forms.ToolStripMenuItem();
            this.presençasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCad_aluno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCad_Aux = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCad_Prof = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCad_Turma = new System.Windows.Forms.ToolStripMenuItem();
            this.experimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaExperimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "SPA - Sistema de Presença Alunos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "RA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Turma:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código Professor:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código Auxiliar:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Temperatura Aluno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Temperatura Professor:";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(368, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Temperatura Auxiliar:";
            // 
            // txbCodProf
            // 
            this.txbCodProf.Location = new System.Drawing.Point(156, 121);
            this.txbCodProf.Name = "txbCodProf";
            this.txbCodProf.Size = new System.Drawing.Size(110, 20);
            this.txbCodProf.TabIndex = 1;
            this.txbCodProf.TextChanged += new System.EventHandler(this.txbCodProf_TextChanged);
            // 
            // txbTempProf
            // 
            this.txbTempProf.Location = new System.Drawing.Point(530, 121);
            this.txbTempProf.Name = "txbTempProf";
            this.txbTempProf.Size = new System.Drawing.Size(110, 20);
            this.txbTempProf.TabIndex = 2;
            // 
            // txbCodAux
            // 
            this.txbCodAux.Location = new System.Drawing.Point(156, 152);
            this.txbCodAux.Name = "txbCodAux";
            this.txbCodAux.Size = new System.Drawing.Size(110, 20);
            this.txbCodAux.TabIndex = 3;
            // 
            // txbTempAux
            // 
            this.txbTempAux.Location = new System.Drawing.Point(530, 152);
            this.txbTempAux.Name = "txbTempAux";
            this.txbTempAux.Size = new System.Drawing.Size(110, 20);
            this.txbTempAux.TabIndex = 4;
            // 
            // txbRA
            // 
            this.txbRA.Location = new System.Drawing.Point(57, 203);
            this.txbRA.Name = "txbRA";
            this.txbRA.Size = new System.Drawing.Size(110, 20);
            this.txbRA.TabIndex = 5;
            // 
            // txbTurma
            // 
            this.txbTurma.Location = new System.Drawing.Point(248, 203);
            this.txbTurma.Name = "txbTurma";
            this.txbTurma.Size = new System.Drawing.Size(110, 20);
            this.txbTurma.TabIndex = 6;
            // 
            // txbTempAluno
            // 
            this.txbTempAluno.Location = new System.Drawing.Point(532, 202);
            this.txbTempAluno.Name = "txbTempAluno";
            this.txbTempAluno.Size = new System.Drawing.Size(110, 20);
            this.txbTempAluno.TabIndex = 7;
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btInserir.Location = new System.Drawing.Point(438, 238);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(204, 78);
            this.btInserir.TabIndex = 9;
            this.btInserir.Text = "Inserir no sistema";
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbObservacao
            // 
            this.txbObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbObservacao.Location = new System.Drawing.Point(23, 258);
            this.txbObservacao.Multiline = true;
            this.txbObservacao.Name = "txbObservacao";
            this.txbObservacao.Size = new System.Drawing.Size(365, 58);
            this.txbObservacao.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(20, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Observações:";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_Ocorrencia,
            this.Tsmi_Consulta,
            this.cadastrarToolStripMenuItem,
            this.reservaExperimentoToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(654, 24);
            this.Menu.TabIndex = 25;
            this.Menu.Text = "menuStrip1";
            // 
            // Tsmi_Ocorrencia
            // 
            this.Tsmi_Ocorrencia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.Tsmi_Ocorrencia.Name = "Tsmi_Ocorrencia";
            this.Tsmi_Ocorrencia.Size = new System.Drawing.Size(77, 20);
            this.Tsmi_Ocorrencia.Text = "Ocorrência";
            this.Tsmi_Ocorrencia.Click += new System.EventHandler(this.Tsmi_Chamado_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // Tsmi_Consulta
            // 
            this.Tsmi_Consulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presençasToolStripMenuItem});
            this.Tsmi_Consulta.Name = "Tsmi_Consulta";
            this.Tsmi_Consulta.Size = new System.Drawing.Size(66, 20);
            this.Tsmi_Consulta.Text = "Consulta";
            this.Tsmi_Consulta.Click += new System.EventHandler(this.Tsmi_Consulta_Click);
            // 
            // presençasToolStripMenuItem
            // 
            this.presençasToolStripMenuItem.Name = "presençasToolStripMenuItem";
            this.presençasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.presençasToolStripMenuItem.Text = "Presenças";
            this.presençasToolStripMenuItem.Click += new System.EventHandler(this.presençasToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCad_aluno,
            this.tsCad_Aux,
            this.tsCad_Prof,
            this.tsCad_Turma,
            this.experimentosToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // tsCad_aluno
            // 
            this.tsCad_aluno.Name = "tsCad_aluno";
            this.tsCad_aluno.Size = new System.Drawing.Size(180, 22);
            this.tsCad_aluno.Text = "Aluno";
            this.tsCad_aluno.Click += new System.EventHandler(this.tsCad_aluno_Click);
            // 
            // tsCad_Aux
            // 
            this.tsCad_Aux.Name = "tsCad_Aux";
            this.tsCad_Aux.Size = new System.Drawing.Size(180, 22);
            this.tsCad_Aux.Text = "Auxiliar";
            this.tsCad_Aux.Click += new System.EventHandler(this.tsCad_Aux_Click);
            // 
            // tsCad_Prof
            // 
            this.tsCad_Prof.Name = "tsCad_Prof";
            this.tsCad_Prof.Size = new System.Drawing.Size(180, 22);
            this.tsCad_Prof.Text = "Professor";
            this.tsCad_Prof.Click += new System.EventHandler(this.tsCad_Prof_Click);
            // 
            // tsCad_Turma
            // 
            this.tsCad_Turma.Name = "tsCad_Turma";
            this.tsCad_Turma.Size = new System.Drawing.Size(180, 22);
            this.tsCad_Turma.Text = "Turma";
            this.tsCad_Turma.Click += new System.EventHandler(this.tsCad_Turma_Click);
            // 
            // experimentosToolStripMenuItem
            // 
            this.experimentosToolStripMenuItem.Name = "experimentosToolStripMenuItem";
            this.experimentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.experimentosToolStripMenuItem.Text = "Experimentos";
            this.experimentosToolStripMenuItem.Click += new System.EventHandler(this.experimentosToolStripMenuItem_Click);
            // 
            // reservaExperimentoToolStripMenuItem
            // 
            this.reservaExperimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservarToolStripMenuItem,
            this.consultarReservasToolStripMenuItem});
            this.reservaExperimentoToolStripMenuItem.Name = "reservaExperimentoToolStripMenuItem";
            this.reservaExperimentoToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.reservaExperimentoToolStripMenuItem.Text = "Experimentos";
            this.reservaExperimentoToolStripMenuItem.Click += new System.EventHandler(this.reservaExperimentoToolStripMenuItem_Click);
            // 
            // reservarToolStripMenuItem
            // 
            this.reservarToolStripMenuItem.Name = "reservarToolStripMenuItem";
            this.reservarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reservarToolStripMenuItem.Text = "Reservar";
            this.reservarToolStripMenuItem.Click += new System.EventHandler(this.reservarToolStripMenuItem_Click);
            // 
            // consultarReservasToolStripMenuItem
            // 
            this.consultarReservasToolStripMenuItem.Name = "consultarReservasToolStripMenuItem";
            this.consultarReservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarReservasToolStripMenuItem.Text = "Consultar Reservas";
            this.consultarReservasToolStripMenuItem.Click += new System.EventHandler(this.consultarReservasToolStripMenuItem_Click);
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 328);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.txbObservacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.txbTempAluno);
            this.Controls.Add(this.txbTurma);
            this.Controls.Add(this.txbRA);
            this.Controls.Add(this.txbTempAux);
            this.Controls.Add(this.txbCodAux);
            this.Controls.Add(this.txbTempProf);
            this.Controls.Add(this.txbCodProf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_Inicial";
            this.ShowIcon = false;
            this.Text = "SPA - Sistema de Presença Alunos";
            this.Load += new System.EventHandler(this.Tela_Inicial_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbCodProf;
        private System.Windows.Forms.TextBox txbTempProf;
        private System.Windows.Forms.TextBox txbCodAux;
        private System.Windows.Forms.TextBox txbTempAux;
        private System.Windows.Forms.TextBox txbRA;
        private System.Windows.Forms.TextBox txbTurma;
        private System.Windows.Forms.TextBox txbTempAluno;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.TextBox txbObservacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Ocorrencia;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Consulta;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsCad_aluno;
        private System.Windows.Forms.ToolStripMenuItem tsCad_Aux;
        private System.Windows.Forms.ToolStripMenuItem tsCad_Prof;
        private System.Windows.Forms.ToolStripMenuItem tsCad_Turma;
        private System.Windows.Forms.ToolStripMenuItem reservaExperimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presençasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem experimentosToolStripMenuItem;
    }
}

