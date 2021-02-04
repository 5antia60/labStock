namespace LabEstoque.Apresentação
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUsuários = new System.Windows.Forms.ToolStripMenuItem();
            this.itensComPatrimônioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empréstimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSPA = new System.Windows.Forms.Button();
            this.btnManutenção = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsaToolStripMenuItem,
            this.emprestarToolStripMenuItem,
            this.devolverToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // dsaToolStripMenuItem
            // 
            this.dsaToolStripMenuItem.Name = "dsaToolStripMenuItem";
            this.dsaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dsaToolStripMenuItem.Text = "Cadastrar cliente";
            this.dsaToolStripMenuItem.Click += new System.EventHandler(this.dsaToolStripMenuItem_Click);
            // 
            // emprestarToolStripMenuItem
            // 
            this.emprestarToolStripMenuItem.Name = "emprestarToolStripMenuItem";
            this.emprestarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.emprestarToolStripMenuItem.Text = "Emprestar";
            this.emprestarToolStripMenuItem.Click += new System.EventHandler(this.emprestarToolStripMenuItem_Click);
            // 
            // devolverToolStripMenuItem
            // 
            this.devolverToolStripMenuItem.Name = "devolverToolStripMenuItem";
            this.devolverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.devolverToolStripMenuItem.Text = "Devolver";
            this.devolverToolStripMenuItem.Click += new System.EventHandler(this.devolverToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClientes,
            this.tsEstoque,
            this.tsUsuários,
            this.itensComPatrimônioToolStripMenuItem,
            this.empréstimosToolStripMenuItem,
            this.devoluçõesToolStripMenuItem,
            this.manutençõesToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultasToolStripMenuItem.Text = "Consultar";
            // 
            // tsClientes
            // 
            this.tsClientes.Name = "tsClientes";
            this.tsClientes.Size = new System.Drawing.Size(188, 22);
            this.tsClientes.Text = "Clientes (registros)";
            this.tsClientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // tsEstoque
            // 
            this.tsEstoque.Name = "tsEstoque";
            this.tsEstoque.Size = new System.Drawing.Size(188, 22);
            this.tsEstoque.Text = "Estoque";
            this.tsEstoque.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // tsUsuários
            // 
            this.tsUsuários.Name = "tsUsuários";
            this.tsUsuários.Size = new System.Drawing.Size(188, 22);
            this.tsUsuários.Text = "Usuários";
            this.tsUsuários.Click += new System.EventHandler(this.tsUsuários_Click);
            // 
            // itensComPatrimônioToolStripMenuItem
            // 
            this.itensComPatrimônioToolStripMenuItem.Name = "itensComPatrimônioToolStripMenuItem";
            this.itensComPatrimônioToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.itensComPatrimônioToolStripMenuItem.Text = "Itens com patrimônio";
            this.itensComPatrimônioToolStripMenuItem.Click += new System.EventHandler(this.itensComPatrimônioToolStripMenuItem_Click);
            // 
            // empréstimosToolStripMenuItem
            // 
            this.empréstimosToolStripMenuItem.Name = "empréstimosToolStripMenuItem";
            this.empréstimosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.empréstimosToolStripMenuItem.Text = "Empréstimos";
            this.empréstimosToolStripMenuItem.Click += new System.EventHandler(this.empréstimosToolStripMenuItem_Click);
            // 
            // devoluçõesToolStripMenuItem
            // 
            this.devoluçõesToolStripMenuItem.Name = "devoluçõesToolStripMenuItem";
            this.devoluçõesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.devoluçõesToolStripMenuItem.Text = "Devoluções";
            this.devoluçõesToolStripMenuItem.Click += new System.EventHandler(this.devoluçõesToolStripMenuItem_Click);
            // 
            // manutençõesToolStripMenuItem
            // 
            this.manutençõesToolStripMenuItem.Name = "manutençõesToolStripMenuItem";
            this.manutençõesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.manutençõesToolStripMenuItem.Text = "Manutenções";
            this.manutençõesToolStripMenuItem.Click += new System.EventHandler(this.manutençõesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(115, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(135, 253);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(47, 20);
            this.lblNivel.TabIndex = 10;
            this.lblNivel.Text = "Nivel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bem-Vindo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cadastro de\r\n  clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "Emprestar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 31);
            this.button3.TabIndex = 14;
            this.button3.Text = "Devolver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSPA
            // 
            this.btnSPA.Location = new System.Drawing.Point(142, 139);
            this.btnSPA.Name = "btnSPA";
            this.btnSPA.Size = new System.Drawing.Size(87, 54);
            this.btnSPA.TabIndex = 15;
            this.btnSPA.Text = "SPA - Sistema\r\nPresença\r\n Alunos";
            this.btnSPA.UseVisualStyleBackColor = true;
            this.btnSPA.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnManutenção
            // 
            this.btnManutenção.Location = new System.Drawing.Point(101, 102);
            this.btnManutenção.Name = "btnManutenção";
            this.btnManutenção.Size = new System.Drawing.Size(76, 31);
            this.btnManutenção.TabIndex = 16;
            this.btnManutenção.Text = "Manutenção";
            this.btnManutenção.UseVisualStyleBackColor = true;
            this.btnManutenção.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(279, 282);
            this.Controls.Add(this.btnManutenção);
            this.Controls.Add(this.btnSPA);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Menu principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.LoginConsulta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprestarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsClientes;
        private System.Windows.Forms.ToolStripMenuItem tsEstoque;
        private System.Windows.Forms.ToolStripMenuItem tsUsuários;
        private System.Windows.Forms.ToolStripMenuItem empréstimosToolStripMenuItem;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem devoluçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itensComPatrimônioToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSPA;
        private System.Windows.Forms.Button btnManutenção;
        private System.Windows.Forms.ToolStripMenuItem manutençõesToolStripMenuItem;
    }
}