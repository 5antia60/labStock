namespace LabEstoque
{
    partial class FormEmpréstimo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpréstimo));
            this.label1 = new System.Windows.Forms.Label();
            this.txbEmpItem = new System.Windows.Forms.TextBox();
            this.tblEstoqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txbEmpQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEmpPatrimônio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEmpRegistro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.txbEmpData = new System.Windows.Forms.MaskedTextBox();
            this.txbEmpDevolução = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txbEmpResponsavel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbEmpPesquisa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbEmpSetorMateria = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.dgItensEmprestar = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPatrimônio = new System.Windows.Forms.Button();
            this.txbEmpEspécie = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAmpliarImg = new System.Windows.Forms.Button();
            this.lblFotoNull = new System.Windows.Forms.Label();
            this.formEmpréstimoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblEstoqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItensEmprestar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formEmpréstimoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbEmpItem
            // 
            this.txbEmpItem.Location = new System.Drawing.Point(53, 19);
            this.txbEmpItem.Name = "txbEmpItem";
            this.txbEmpItem.Size = new System.Drawing.Size(270, 20);
            this.txbEmpItem.TabIndex = 2;
            this.txbEmpItem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tblEstoqueBindingSource1
            // 
            this.tblEstoqueBindingSource1.DataMember = "tblEstoque";
            // 
            // labArmarioDataSet21
            // 
            // 
            // tblEstoqueBindingSource
            // 
            this.tblEstoqueBindingSource.DataMember = "tblEstoque";
            // 
            // labArmarioDataSet1
            // 
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbEmpQuantidade
            // 
            this.txbEmpQuantidade.Location = new System.Drawing.Point(84, 45);
            this.txbEmpQuantidade.Name = "txbEmpQuantidade";
            this.txbEmpQuantidade.Size = new System.Drawing.Size(23, 20);
            this.txbEmpQuantidade.TabIndex = 3;
            this.txbEmpQuantidade.Text = "0";
            this.txbEmpQuantidade.TextChanged += new System.EventHandler(this.txbEmpQuantidade_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patrimônio:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbEmpPatrimônio
            // 
            this.txbEmpPatrimônio.Location = new System.Drawing.Point(84, 95);
            this.txbEmpPatrimônio.Name = "txbEmpPatrimônio";
            this.txbEmpPatrimônio.Size = new System.Drawing.Size(87, 20);
            this.txbEmpPatrimônio.TabIndex = 5;
            this.txbEmpPatrimônio.TextChanged += new System.EventHandler(this.txbEmpPatrimônio_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Previsão de Devoução:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Registro:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txbEmpRegistro
            // 
            this.txbEmpRegistro.Location = new System.Drawing.Point(83, 115);
            this.txbEmpRegistro.Name = "txbEmpRegistro";
            this.txbEmpRegistro.Size = new System.Drawing.Size(115, 20);
            this.txbEmpRegistro.TabIndex = 12;
            this.txbEmpRegistro.TextChanged += new System.EventHandler(this.txbEmpRegistro_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Emprestar";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Location = new System.Drawing.Point(214, 115);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(118, 21);
            this.btnEmprestar.TabIndex = 13;
            this.btnEmprestar.Text = "Emprestar";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // txbEmpData
            // 
            this.txbEmpData.Location = new System.Drawing.Point(62, 19);
            this.txbEmpData.Mask = "00/00/0000";
            this.txbEmpData.Name = "txbEmpData";
            this.txbEmpData.Size = new System.Drawing.Size(65, 20);
            this.txbEmpData.TabIndex = 8;
            this.txbEmpData.ValidatingType = typeof(System.DateTime);
            this.txbEmpData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txbEmpData_MaskInputRejected);
            // 
            // txbEmpDevolução
            // 
            this.txbEmpDevolução.Location = new System.Drawing.Point(267, 19);
            this.txbEmpDevolução.Mask = "00/00/0000";
            this.txbEmpDevolução.Name = "txbEmpDevolução";
            this.txbEmpDevolução.Size = new System.Drawing.Size(65, 20);
            this.txbEmpDevolução.TabIndex = 9;
            this.txbEmpDevolução.ValidatingType = typeof(System.DateTime);
            this.txbEmpDevolução.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txbEmpDevolução_MaskInputRejected);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(977, 267);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "  Responsável\r\npelo empréstimo:\r\n";
            // 
            // txbEmpResponsavel
            // 
            this.txbEmpResponsavel.Location = new System.Drawing.Point(106, 54);
            this.txbEmpResponsavel.Name = "txbEmpResponsavel";
            this.txbEmpResponsavel.Size = new System.Drawing.Size(226, 20);
            this.txbEmpResponsavel.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tabela do estoque:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(313, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Pesquisar item:";
            // 
            // txbEmpPesquisa
            // 
            this.txbEmpPesquisa.Location = new System.Drawing.Point(451, 100);
            this.txbEmpPesquisa.Name = "txbEmpPesquisa";
            this.txbEmpPesquisa.Size = new System.Drawing.Size(178, 20);
            this.txbEmpPesquisa.TabIndex = 15;
            this.txbEmpPesquisa.TextChanged += new System.EventHandler(this.txbEmpPesquisa_TextChanged);
            // 
            // tblEstoqueTableAdapter
            // 
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Setor / Matéria do cliente:";
            // 
            // txbEmpSetorMateria
            // 
            this.txbEmpSetorMateria.Location = new System.Drawing.Point(164, 89);
            this.txbEmpSetorMateria.Name = "txbEmpSetorMateria";
            this.txbEmpSetorMateria.Size = new System.Drawing.Size(168, 20);
            this.txbEmpSetorMateria.TabIndex = 11;
            // 
            // labArmarioDataSet2
            // 
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(267, 45);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(56, 46);
            this.btnADD.TabIndex = 7;
            this.btnADD.Text = "Escolher";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // dgItensEmprestar
            // 
            this.dgItensEmprestar.AllowUserToAddRows = false;
            this.dgItensEmprestar.AllowUserToDeleteRows = false;
            this.dgItensEmprestar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgItensEmprestar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItensEmprestar.Location = new System.Drawing.Point(377, 420);
            this.dgItensEmprestar.Name = "dgItensEmprestar";
            this.dgItensEmprestar.ReadOnly = true;
            this.dgItensEmprestar.Size = new System.Drawing.Size(612, 251);
            this.dgItensEmprestar.TabIndex = 23;
            this.dgItensEmprestar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItensEmprestar_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(377, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Itens para emprestar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbEmpDevolução);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbEmpSetorMateria);
            this.groupBox1.Controls.Add(this.txbEmpRegistro);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnEmprestar);
            this.groupBox1.Controls.Add(this.txbEmpData);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbEmpResponsavel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 527);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do empréstimo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbDescricao);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnPatrimônio);
            this.groupBox2.Controls.Add(this.txbEmpEspécie);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txbEmpItem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txbEmpQuantidade);
            this.groupBox2.Controls.Add(this.btnADD);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txbEmpPatrimônio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escolha itens para emprestar";
            // 
            // btnPatrimônio
            // 
            this.btnPatrimônio.Location = new System.Drawing.Point(214, 95);
            this.btnPatrimônio.Name = "btnPatrimônio";
            this.btnPatrimônio.Size = new System.Drawing.Size(108, 21);
            this.btnPatrimônio.TabIndex = 6;
            this.btnPatrimônio.Text = "Buscar Patrimônio";
            this.btnPatrimônio.UseVisualStyleBackColor = true;
            this.btnPatrimônio.Click += new System.EventHandler(this.btnPatrimônio_Click);
            // 
            // txbEmpEspécie
            // 
            this.txbEmpEspécie.Enabled = false;
            this.txbEmpEspécie.Location = new System.Drawing.Point(177, 45);
            this.txbEmpEspécie.Name = "txbEmpEspécie";
            this.txbEmpEspécie.Size = new System.Drawing.Size(84, 20);
            this.txbEmpEspécie.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(123, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Espécie:";
            // 
            // tblEstoqueTableAdapter1
            // 
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(752, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnAmpliarImg
            // 
            this.btnAmpliarImg.Location = new System.Drawing.Point(914, 77);
            this.btnAmpliarImg.Name = "btnAmpliarImg";
            this.btnAmpliarImg.Size = new System.Drawing.Size(75, 43);
            this.btnAmpliarImg.TabIndex = 26;
            this.btnAmpliarImg.Text = "Ampliar\r\nImagem";
            this.btnAmpliarImg.UseVisualStyleBackColor = true;
            this.btnAmpliarImg.Click += new System.EventHandler(this.btnAmpliarImg_Click);
            // 
            // lblFotoNull
            // 
            this.lblFotoNull.AutoSize = true;
            this.lblFotoNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFotoNull.Location = new System.Drawing.Point(780, 31);
            this.lblFotoNull.Name = "lblFotoNull";
            this.lblFotoNull.Size = new System.Drawing.Size(110, 72);
            this.lblFotoNull.TabIndex = 27;
            this.lblFotoNull.Text = "Nenhuma \r\n Imagem \r\ndisponivel...";
            // 
            // formEmpréstimoBindingSource
            // 
            this.formEmpréstimoBindingSource.DataSource = typeof(LabEstoque.FormEmpréstimo);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Descrição:";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(84, 70);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(87, 20);
            this.txbDescricao.TabIndex = 9;
            // 
            // FormEmpréstimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 683);
            this.Controls.Add(this.lblFotoNull);
            this.Controls.Add(this.btnAmpliarImg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgItensEmprestar);
            this.Controls.Add(this.txbEmpPesquisa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmpréstimo";
            this.Text = "Emprestar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblEstoqueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItensEmprestar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formEmpréstimoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEmpQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEmpRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.MaskedTextBox txbEmpData;
        private System.Windows.Forms.MaskedTextBox txbEmpDevolução;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbEmpResponsavel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbEmpPesquisa;
        private System.Windows.Forms.BindingSource tblEstoqueBindingSource;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbEmpSetorMateria;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.DataGridView dgItensEmprestar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource tblEstoqueBindingSource1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbEmpEspécie;
        private System.Windows.Forms.Button btnPatrimônio;
        public System.Windows.Forms.TextBox txbEmpItem;
        private System.Windows.Forms.BindingSource formEmpréstimoBindingSource;
        public System.Windows.Forms.TextBox txbEmpPatrimônio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAmpliarImg;
        private System.Windows.Forms.Label lblFotoNull;
        public System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label label14;
    }
}

