namespace LabEstoque.Apresentação
{
    partial class ConsultaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEstoque));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbPesqColuna = new System.Windows.Forms.ComboBox();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDescrição = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbQntAtual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbQntTotal = new System.Windows.Forms.TextBox();
            this.txbItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnApagarImg = new System.Windows.Forms.Button();
            this.lblFotoNull = new System.Windows.Forms.Label();
            this.btnMostrarImg = new System.Windows.Forms.Button();
            this.btnSalvarImg = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbSala = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbArmario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbEspecie = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbClassificacao = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txbPesqColuna);
            this.groupBox1.Controls.Add(this.txbPesquisa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Linha:";
            // 
            // txbPesqColuna
            // 
            this.txbPesqColuna.FormattingEnabled = true;
            this.txbPesqColuna.Items.AddRange(new object[] {
            "ID",
            "Item",
            "Quantidade_Total",
            "Quantidade_Atual",
            "Descrição",
            "Sala",
            "Armário",
            "Espécie",
            "Classificação"});
            this.txbPesqColuna.Location = new System.Drawing.Point(32, 42);
            this.txbPesqColuna.Name = "txbPesqColuna";
            this.txbPesqColuna.Size = new System.Drawing.Size(201, 21);
            this.txbPesqColuna.TabIndex = 10;
            this.txbPesqColuna.Text = "Item";
            this.txbPesqColuna.TextUpdate += new System.EventHandler(this.txbPesqColuna_TextUpdate);
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(32, 98);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(201, 20);
            this.txbPesquisa.TabIndex = 1;
            this.txbPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coluna:";
            // 
            // datagridview1
            // 
            this.datagridview1.AllowUserToAddRows = false;
            this.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.Location = new System.Drawing.Point(12, 174);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.ReadOnly = true;
            this.datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview1.Size = new System.Drawing.Size(1114, 372);
            this.datagridview1.TabIndex = 2;
            this.datagridview1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.datagridview1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbClassificacao);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txbEspecie);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txbArmario);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txbSala);
            this.groupBox2.Controls.Add(this.txbID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnAdicionar);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.txbDescrição);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnApagar);
            this.groupBox2.Controls.Add(this.btnAlterar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbQntAtual);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txbQntTotal);
            this.groupBox2.Controls.Add(this.txbItem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(257, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 132);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gerenciar dados da tabela";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(247, 45);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(49, 20);
            this.txbID.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "ID:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(376, 45);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(119, 20);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar Linha";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(313, 44);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(57, 47);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(376, 98);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(119, 22);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.TabStop = false;
            this.btnApagar.Text = "Apagar Linha";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(376, 71);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(119, 21);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar Linha";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sala:";
            // 
            // txbDescrição
            // 
            this.txbDescrição.Location = new System.Drawing.Point(87, 72);
            this.txbDescrição.Name = "txbDescrição";
            this.txbDescrição.Size = new System.Drawing.Size(61, 20);
            this.txbDescrição.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descrição:";
            // 
            // txbQntAtual
            // 
            this.txbQntAtual.Location = new System.Drawing.Point(188, 45);
            this.txbQntAtual.Name = "txbQntAtual";
            this.txbQntAtual.Size = new System.Drawing.Size(31, 20);
            this.txbQntAtual.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Atual:";
            // 
            // txbQntTotal
            // 
            this.txbQntTotal.Location = new System.Drawing.Point(117, 45);
            this.txbQntTotal.Name = "txbQntTotal";
            this.txbQntTotal.Size = new System.Drawing.Size(31, 20);
            this.txbQntTotal.TabIndex = 3;
            // 
            // txbItem
            // 
            this.txbItem.Location = new System.Drawing.Point(42, 19);
            this.txbItem.Name = "txbItem";
            this.txbItem.Size = new System.Drawing.Size(452, 20);
            this.txbItem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade... Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Item:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(531, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Estoque";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnApagarImg);
            this.groupBox3.Controls.Add(this.lblFotoNull);
            this.groupBox3.Controls.Add(this.btnMostrarImg);
            this.groupBox3.Controls.Add(this.btnSalvarImg);
            this.groupBox3.Controls.Add(this.btnInserir);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(763, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 164);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gerenciar imagens";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnApagarImg
            // 
            this.btnApagarImg.Location = new System.Drawing.Point(200, 90);
            this.btnApagarImg.Name = "btnApagarImg";
            this.btnApagarImg.Size = new System.Drawing.Size(137, 34);
            this.btnApagarImg.TabIndex = 11;
            this.btnApagarImg.Text = "Apagar imagem\r\n  do sistema";
            this.btnApagarImg.UseVisualStyleBackColor = true;
            this.btnApagarImg.Click += new System.EventHandler(this.btnApagarImg_Click);
            // 
            // lblFotoNull
            // 
            this.lblFotoNull.AutoSize = true;
            this.lblFotoNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFotoNull.Location = new System.Drawing.Point(43, 47);
            this.lblFotoNull.Name = "lblFotoNull";
            this.lblFotoNull.Size = new System.Drawing.Size(110, 72);
            this.lblFotoNull.TabIndex = 10;
            this.lblFotoNull.Text = "Nenhuma \r\n Imagem \r\ndisponivel...";
            this.lblFotoNull.Click += new System.EventHandler(this.lblFotoNull_Click);
            // 
            // btnMostrarImg
            // 
            this.btnMostrarImg.Location = new System.Drawing.Point(200, 130);
            this.btnMostrarImg.Name = "btnMostrarImg";
            this.btnMostrarImg.Size = new System.Drawing.Size(137, 28);
            this.btnMostrarImg.TabIndex = 3;
            this.btnMostrarImg.Text = "Ampliar imagem";
            this.btnMostrarImg.UseVisualStyleBackColor = true;
            this.btnMostrarImg.Click += new System.EventHandler(this.btnMostrarImg_Click);
            // 
            // btnSalvarImg
            // 
            this.btnSalvarImg.Location = new System.Drawing.Point(200, 51);
            this.btnSalvarImg.Name = "btnSalvarImg";
            this.btnSalvarImg.Size = new System.Drawing.Size(137, 36);
            this.btnSalvarImg.TabIndex = 2;
            this.btnSalvarImg.Text = "Atualizar imagem\r\n    do sistema";
            this.btnSalvarImg.UseVisualStyleBackColor = true;
            this.btnSalvarImg.Click += new System.EventHandler(this.btnSalvarImg_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(200, 16);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(137, 29);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir imagem";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txbSala
            // 
            this.txbSala.Location = new System.Drawing.Point(188, 71);
            this.txbSala.Name = "txbSala";
            this.txbSala.Size = new System.Drawing.Size(31, 20);
            this.txbSala.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(225, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Armário:";
            // 
            // txbArmario
            // 
            this.txbArmario.Location = new System.Drawing.Point(281, 70);
            this.txbArmario.Name = "txbArmario";
            this.txbArmario.Size = new System.Drawing.Size(26, 20);
            this.txbArmario.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Espécie:";
            // 
            // txbEspecie
            // 
            this.txbEspecie.FormattingEnabled = true;
            this.txbEspecie.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.txbEspecie.Location = new System.Drawing.Point(78, 98);
            this.txbEspecie.Name = "txbEspecie";
            this.txbEspecie.Size = new System.Drawing.Size(61, 21);
            this.txbEspecie.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(180, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Classificação:";
            // 
            // txbClassificacao
            // 
            this.txbClassificacao.FormattingEnabled = true;
            this.txbClassificacao.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.txbClassificacao.Location = new System.Drawing.Point(278, 96);
            this.txbClassificacao.Name = "txbClassificacao";
            this.txbClassificacao.Size = new System.Drawing.Size(66, 21);
            this.txbClassificacao.TabIndex = 34;
            // 
            // ConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 558);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datagridview1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaEstoque";
            this.Text = "Consulta de estoque";
            this.Load += new System.EventHandler(this.ConsultaEstoque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbDescrição;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbQntAtual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbQntTotal;
        private System.Windows.Forms.TextBox txbItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnMostrarImg;
        private System.Windows.Forms.Button btnSalvarImg;
        private System.Windows.Forms.Label lblFotoNull;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Button btnApagarImg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txbPesqColuna;
        private System.Windows.Forms.ComboBox txbClassificacao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txbEspecie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbArmario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbSala;
    }
}