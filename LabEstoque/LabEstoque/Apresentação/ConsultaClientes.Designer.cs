namespace LabEstoque.Apresentação
{
    partial class ConsultaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaClientes));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbPesquisaRegistro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPesquisaNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbStatus = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbTelefone2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbRegistro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbEndereço = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 167);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1226, 343);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbPesquisaRegistro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbPesquisaNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(110, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa na tabela";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txbPesquisaRegistro
            // 
            this.txbPesquisaRegistro.Location = new System.Drawing.Point(160, 74);
            this.txbPesquisaRegistro.Name = "txbPesquisaRegistro";
            this.txbPesquisaRegistro.Size = new System.Drawing.Size(103, 20);
            this.txbPesquisaRegistro.TabIndex = 2;
            this.txbPesquisaRegistro.TextChanged += new System.EventHandler(this.txbPesquisaRegistro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pesquisar registro:";
            // 
            // txbPesquisaNome
            // 
            this.txbPesquisaNome.Location = new System.Drawing.Point(142, 28);
            this.txbPesquisaNome.Name = "txbPesquisaNome";
            this.txbPesquisaNome.Size = new System.Drawing.Size(164, 20);
            this.txbPesquisaNome.TabIndex = 1;
            this.txbPesquisaNome.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbStatus);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.txbID);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnAdicionar);
            this.groupBox2.Controls.Add(this.btnApagar);
            this.groupBox2.Controls.Add(this.btnAlterar);
            this.groupBox2.Controls.Add(this.txbEmail);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txbTelefone2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txbRegistro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txbTelefone);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txbEndereço);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbCPF);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txbRG);
            this.groupBox2.Controls.Add(this.txbNome);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(452, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(701, 126);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gerenciar dados da tabela";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txbStatus
            // 
            this.txbStatus.FormattingEnabled = true;
            this.txbStatus.Items.AddRange(new object[] {
            "Aluno(a)",
            "Monitor(a)",
            "Estagiário(a)",
            "Funcionário(a)",
            "Professor(a)",
            "Coordenador(a)"});
            this.txbStatus.Location = new System.Drawing.Point(72, 96);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(104, 21);
            this.txbStatus.TabIndex = 7;
            this.txbStatus.Text = "Selecionar";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(576, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(119, 22);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(509, 98);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(39, 20);
            this.txbID.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(482, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "ID:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(576, 96);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(119, 22);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar Linha";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(576, 40);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(119, 22);
            this.btnApagar.TabIndex = 12;
            this.btnApagar.Text = "Apagar Linha";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(576, 68);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(119, 22);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar Linha";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(72, 71);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(145, 20);
            this.txbEmail.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Email:";
            // 
            // txbTelefone2
            // 
            this.txbTelefone2.Location = new System.Drawing.Point(387, 97);
            this.txbTelefone2.Name = "txbTelefone2";
            this.txbTelefone2.Size = new System.Drawing.Size(89, 20);
            this.txbTelefone2.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(315, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Telefone 2:";
            // 
            // txbRegistro
            // 
            this.txbRegistro.Location = new System.Drawing.Point(243, 96);
            this.txbRegistro.Name = "txbRegistro";
            this.txbRegistro.Size = new System.Drawing.Size(66, 20);
            this.txbRegistro.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(182, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Registro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(258, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefone:";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(329, 20);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(78, 20);
            this.txbTelefone.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Status:";
            // 
            // txbEndereço
            // 
            this.txbEndereço.Location = new System.Drawing.Point(234, 46);
            this.txbEndereço.Multiline = true;
            this.txbEndereço.Name = "txbEndereço";
            this.txbEndereço.Size = new System.Drawing.Size(314, 46);
            this.txbEndereço.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(158, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "CPF:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(456, 20);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(92, 20);
            this.txbCPF.TabIndex = 3;
            this.txbCPF.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "RG:";
            // 
            // txbRG
            // 
            this.txbRG.Location = new System.Drawing.Point(72, 45);
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(71, 20);
            this.txbRG.TabIndex = 4;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(72, 19);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(180, 20);
            this.txbNome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clientes (Registros)";
            // 
            // ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaClientes";
            this.Text = "Consulta de clientes";
            this.Load += new System.EventHandler(this.ConsultaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbPesquisaNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPesquisaRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbTelefone2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbRegistro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbEndereço;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox txbStatus;
    }
}