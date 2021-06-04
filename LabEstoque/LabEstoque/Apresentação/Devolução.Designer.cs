namespace LabEstoque
{
    partial class FormDevolução
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevolução));
            this.label7 = new System.Windows.Forms.Label();
            this.txbDevRegistro = new System.Windows.Forms.TextBox();
            this.tblEmpréstimosBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmpréstimosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmpréstimosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txbDevPatrimonio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDevObservação = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDevQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDevItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.txbDevData = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDevResponsavel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbDevPItem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgItensDevolver = new System.Windows.Forms.DataGridView();
            this.btnDevAdicionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbDevID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tblEmpréstimosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmpréstimosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmpréstimosBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmpréstimosBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmpréstimosBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.txbPesqCol = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItensDevolver)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource6)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(572, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 31);
            this.label7.TabIndex = 27;
            this.label7.Text = "Devolver";
            // 
            // txbDevRegistro
            // 
            this.txbDevRegistro.Location = new System.Drawing.Point(214, 57);
            this.txbDevRegistro.Name = "txbDevRegistro";
            this.txbDevRegistro.Size = new System.Drawing.Size(101, 20);
            this.txbDevRegistro.TabIndex = 9;
            this.txbDevRegistro.TextChanged += new System.EventHandler(this.txbDevIDCliente_TextChanged);
            // 
            // tblEmpréstimosBindingSource7
            // 
            this.tblEmpréstimosBindingSource7.DataMember = "tblEmpréstimos";
            // 
            // labArmarioDataSet6
            // 
            // 
            // tblEmpréstimosBindingSource3
            // 
            this.tblEmpréstimosBindingSource3.DataMember = "tblEmpréstimos";
            // 
            // labArmarioDataSet4
            // 
            // 
            // tblEmpréstimosBindingSource
            // 
            this.tblEmpréstimosBindingSource.DataMember = "tblEmpréstimos";
            // 
            // labArmarioDataSet
            // 
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(159, 60);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(49, 13);
            this.lblRegistro.TabIndex = 24;
            this.lblRegistro.Text = "Registro:";
            this.lblRegistro.Click += new System.EventHandler(this.label6_Click);
            // 
            // txbDevPatrimonio
            // 
            this.txbDevPatrimonio.Location = new System.Drawing.Point(306, 19);
            this.txbDevPatrimonio.Name = "txbDevPatrimonio";
            this.txbDevPatrimonio.Size = new System.Drawing.Size(56, 20);
            this.txbDevPatrimonio.TabIndex = 2;
            this.txbDevPatrimonio.TextChanged += new System.EventHandler(this.txbDevPatrimonio_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Observação:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txbDevObservação
            // 
            this.txbDevObservação.Location = new System.Drawing.Point(81, 45);
            this.txbDevObservação.Multiline = true;
            this.txbDevObservação.Name = "txbDevObservação";
            this.txbDevObservação.Size = new System.Drawing.Size(388, 55);
            this.txbDevObservação.TabIndex = 4;
            this.txbDevObservação.TextChanged += new System.EventHandler(this.txbDevObservação_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Data:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Patrimônio:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbDevQuantidade
            // 
            this.txbDevQuantidade.Location = new System.Drawing.Point(439, 19);
            this.txbDevQuantidade.Name = "txbDevQuantidade";
            this.txbDevQuantidade.Size = new System.Drawing.Size(30, 20);
            this.txbDevQuantidade.TabIndex = 3;
            this.txbDevQuantidade.TextChanged += new System.EventHandler(this.txbDevQuantidade_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Quantidade:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbDevItem
            // 
            this.txbDevItem.Location = new System.Drawing.Point(43, 19);
            this.txbDevItem.Name = "txbDevItem";
            this.txbDevItem.Size = new System.Drawing.Size(192, 20);
            this.txbDevItem.TabIndex = 1;
            this.txbDevItem.TextChanged += new System.EventHandler(this.txbDevItem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Item:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(339, 27);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(131, 50);
            this.btnDevolver.TabIndex = 10;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click_1);
            // 
            // txbDevData
            // 
            this.txbDevData.Location = new System.Drawing.Point(52, 57);
            this.txbDevData.Mask = "00/00/0000";
            this.txbDevData.Name = "txbDevData";
            this.txbDevData.Size = new System.Drawing.Size(66, 20);
            this.txbDevData.TabIndex = 8;
            this.txbDevData.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1219, 306);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 26);
            this.label6.TabIndex = 32;
            this.label6.Text = " Responsavel\r\npela recepção:";
            // 
            // txbDevResponsavel
            // 
            this.txbDevResponsavel.Location = new System.Drawing.Point(97, 27);
            this.txbDevResponsavel.Name = "txbDevResponsavel";
            this.txbDevResponsavel.Size = new System.Drawing.Size(218, 20);
            this.txbDevResponsavel.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Tabela de emprestados:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Coluna:";
            // 
            // txbDevPItem
            // 
            this.txbDevPItem.Location = new System.Drawing.Point(40, 81);
            this.txbDevPItem.Name = "txbDevPItem";
            this.txbDevPItem.Size = new System.Drawing.Size(339, 20);
            this.txbDevPItem.TabIndex = 9;
            this.txbDevPItem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tblEmpréstimosTableAdapter
            // 
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 35;
            this.label10.Text = "Busca:";
            // 
            // dgItensDevolver
            // 
            this.dgItensDevolver.AllowUserToAddRows = false;
            this.dgItensDevolver.AllowUserToDeleteRows = false;
            this.dgItensDevolver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgItensDevolver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItensDevolver.Location = new System.Drawing.Point(512, 458);
            this.dgItensDevolver.Name = "dgItensDevolver";
            this.dgItensDevolver.ReadOnly = true;
            this.dgItensDevolver.Size = new System.Drawing.Size(719, 210);
            this.dgItensDevolver.TabIndex = 37;
            // 
            // btnDevAdicionar
            // 
            this.btnDevAdicionar.Location = new System.Drawing.Point(394, 106);
            this.btnDevAdicionar.Name = "btnDevAdicionar";
            this.btnDevAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnDevAdicionar.TabIndex = 6;
            this.btnDevAdicionar.Text = "Escolher";
            this.btnDevAdicionar.UseVisualStyleBackColor = true;
            this.btnDevAdicionar.Click += new System.EventHandler(this.btnDevAdicionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbDevID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txbDevItem);
            this.groupBox1.Controls.Add(this.btnDevAdicionar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbDevQuantidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbDevObservação);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbDevPatrimonio);
            this.groupBox1.Location = new System.Drawing.Point(12, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha itens para devolver";
            // 
            // txbDevID
            // 
            this.txbDevID.Enabled = false;
            this.txbDevID.Location = new System.Drawing.Point(43, 108);
            this.txbDevID.Name = "txbDevID";
            this.txbDevID.Size = new System.Drawing.Size(69, 20);
            this.txbDevID.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbDevData);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbDevRegistro);
            this.groupBox2.Controls.Add(this.lblRegistro);
            this.groupBox2.Controls.Add(this.btnDevolver);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbDevResponsavel);
            this.groupBox2.Location = new System.Drawing.Point(11, 582);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da devolução";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(513, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 18);
            this.label12.TabIndex = 41;
            this.label12.Text = "Itens para devolver:";
            // 
            // tblEmpréstimosBindingSource1
            // 
            this.tblEmpréstimosBindingSource1.DataMember = "tblEmpréstimos";
            // 
            // labArmarioDataSet3
            // 
            // 
            // tblEmpréstimosBindingSource2
            // 
            this.tblEmpréstimosBindingSource2.DataMember = "tblEmpréstimos";
            // 
            // tblEmpréstimosTableAdapter1
            // 
            // 
            // tblEmpréstimosTableAdapter2
            // 
            // 
            // tblEmpréstimosBindingSource4
            // 
            this.tblEmpréstimosBindingSource4.DataMember = "tblEmpréstimos";
            // 
            // labArmarioDataSet5
            // 
            // 
            // tblEmpréstimosBindingSource5
            // 
            this.tblEmpréstimosBindingSource5.DataMember = "tblEmpréstimos";
            // 
            // tblEmpréstimosTableAdapter3
            // 
            // 
            // tblEmpréstimosBindingSource6
            // 
            this.tblEmpréstimosBindingSource6.DataMember = "tblEmpréstimos";
            // 
            // tblEmpréstimosTableAdapter4
            // 
            // 
            // txbPesqCol
            // 
            this.txbPesqCol.FormattingEnabled = true;
            this.txbPesqCol.Items.AddRange(new object[] {
            "ID",
            "Item",
            "Quantidade",
            "Data",
            "Patrimônio",
            "PrevisãoDeDevolução",
            "Registro",
            "Setor_Materia",
            "Responsavel"});
            this.txbPesqCol.Location = new System.Drawing.Point(40, 37);
            this.txbPesqCol.Name = "txbPesqCol";
            this.txbPesqCol.Size = new System.Drawing.Size(202, 21);
            this.txbPesqCol.TabIndex = 42;
            this.txbPesqCol.Text = "Item";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txbPesqCol);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txbDevPItem);
            this.groupBox3.Location = new System.Drawing.Point(787, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 107);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisa";
            // 
            // FormDevolução
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 680);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgItensDevolver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDevolução";
            this.Text = "Devolver";
            this.Load += new System.EventHandler(this.FormDevolução_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItensDevolver)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpréstimosBindingSource6)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDevRegistro;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TextBox txbDevPatrimonio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDevObservação;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDevQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDevItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.MaskedTextBox txbDevData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbDevResponsavel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbDevPItem;
        private System.Windows.Forms.BindingSource tblEmpréstimosBindingSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgItensDevolver;
        private System.Windows.Forms.Button btnDevAdicionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource tblEmpréstimosBindingSource1;
        private System.Windows.Forms.BindingSource tblEmpréstimosBindingSource2;
        private System.Windows.Forms.BindingSource tblEmpréstimosBindingSource3;
        private System.Windows.Forms.BindingSource tblEmpréstimosBindingSource4;
        private System.Windows.Forms.TextBox txbDevID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource tblEmpréstimosBindingSource5;
        private System.Windows.Forms.BindingSource tblEmpréstimosBindingSource6;
        private System.Windows.Forms.BindingSource tblEmpréstimosBindingSource7;
        private System.Windows.Forms.ComboBox txbPesqCol;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}