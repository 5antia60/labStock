namespace LabEstoque
{
    partial class CadastroConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbCadNome = new System.Windows.Forms.TextBox();
            this.txbCadTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txbCadRG = new System.Windows.Forms.MaskedTextBox();
            this.txbCadCPF = new System.Windows.Forms.MaskedTextBox();
            this.txbCadStatus = new System.Windows.Forms.ComboBox();
            this.txbCadEnd = new System.Windows.Forms.TextBox();
            this.txbCadLogin = new System.Windows.Forms.TextBox();
            this.txbCadSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txbCadConfSenha = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de usuários";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "RG:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Endereço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Senha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Login:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txbCadNome
            // 
            this.txbCadNome.Location = new System.Drawing.Point(72, 53);
            this.txbCadNome.Name = "txbCadNome";
            this.txbCadNome.Size = new System.Drawing.Size(316, 20);
            this.txbCadNome.TabIndex = 9;
            // 
            // txbCadTelefone
            // 
            this.txbCadTelefone.Location = new System.Drawing.Point(74, 79);
            this.txbCadTelefone.Mask = "(99) 00000-0000";
            this.txbCadTelefone.Name = "txbCadTelefone";
            this.txbCadTelefone.Size = new System.Drawing.Size(87, 20);
            this.txbCadTelefone.TabIndex = 10;
            // 
            // txbCadRG
            // 
            this.txbCadRG.Location = new System.Drawing.Point(193, 79);
            this.txbCadRG.Mask = "00,000,000-0";
            this.txbCadRG.Name = "txbCadRG";
            this.txbCadRG.Size = new System.Drawing.Size(74, 20);
            this.txbCadRG.TabIndex = 11;
            // 
            // txbCadCPF
            // 
            this.txbCadCPF.Location = new System.Drawing.Point(303, 79);
            this.txbCadCPF.Mask = "000,000,000-00";
            this.txbCadCPF.Name = "txbCadCPF";
            this.txbCadCPF.Size = new System.Drawing.Size(85, 20);
            this.txbCadCPF.TabIndex = 12;
            // 
            // txbCadStatus
            // 
            this.txbCadStatus.FormattingEnabled = true;
            this.txbCadStatus.Items.AddRange(new object[] {
            "Monitor(a)",
            "Estagiário(a)",
            "Professor(a)",
            "Coordenador(a)",
            "Administrador(a)"});
            this.txbCadStatus.Location = new System.Drawing.Point(74, 217);
            this.txbCadStatus.Name = "txbCadStatus";
            this.txbCadStatus.Size = new System.Drawing.Size(184, 21);
            this.txbCadStatus.TabIndex = 17;
            this.txbCadStatus.Text = "Selecione";
            this.txbCadStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txbCadEnd
            // 
            this.txbCadEnd.Location = new System.Drawing.Point(74, 105);
            this.txbCadEnd.Multiline = true;
            this.txbCadEnd.Name = "txbCadEnd";
            this.txbCadEnd.Size = new System.Drawing.Size(314, 50);
            this.txbCadEnd.TabIndex = 13;
            // 
            // txbCadLogin
            // 
            this.txbCadLogin.Location = new System.Drawing.Point(74, 161);
            this.txbCadLogin.Name = "txbCadLogin";
            this.txbCadLogin.Size = new System.Drawing.Size(137, 20);
            this.txbCadLogin.TabIndex = 14;
            // 
            // txbCadSenha
            // 
            this.txbCadSenha.Location = new System.Drawing.Point(264, 161);
            this.txbCadSenha.Name = "txbCadSenha";
            this.txbCadSenha.PasswordChar = '*';
            this.txbCadSenha.Size = new System.Drawing.Size(124, 20);
            this.txbCadSenha.TabIndex = 15;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(273, 189);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 49);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Confirmar senha:";
            // 
            // txbCadConfSenha
            // 
            this.txbCadConfSenha.Location = new System.Drawing.Point(118, 191);
            this.txbCadConfSenha.Name = "txbCadConfSenha";
            this.txbCadConfSenha.PasswordChar = '*';
            this.txbCadConfSenha.Size = new System.Drawing.Size(140, 20);
            this.txbCadConfSenha.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(243, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Preencha todos os campos...";
            // 
            // CadastroConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 273);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbCadConfSenha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbCadSenha);
            this.Controls.Add(this.txbCadLogin);
            this.Controls.Add(this.txbCadEnd);
            this.Controls.Add(this.txbCadStatus);
            this.Controls.Add(this.txbCadCPF);
            this.Controls.Add(this.txbCadRG);
            this.Controls.Add(this.txbCadTelefone);
            this.Controls.Add(this.txbCadNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroConsulta";
            this.Text = "Cadastro de usuários";
            this.Load += new System.EventHandler(this.CadastroConsulta_Load);
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbCadNome;
        private System.Windows.Forms.MaskedTextBox txbCadTelefone;
        private System.Windows.Forms.MaskedTextBox txbCadRG;
        private System.Windows.Forms.MaskedTextBox txbCadCPF;
        private System.Windows.Forms.ComboBox txbCadStatus;
        private System.Windows.Forms.TextBox txbCadEnd;
        private System.Windows.Forms.TextBox txbCadLogin;
        private System.Windows.Forms.TextBox txbCadSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbCadConfSenha;
        private System.Windows.Forms.Label label11;
    }
}