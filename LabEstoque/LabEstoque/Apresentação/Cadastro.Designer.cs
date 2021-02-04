namespace LabEstoque
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.txbCadNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCadEndereço = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCadRegistro = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbCadTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txbCadRG = new System.Windows.Forms.MaskedTextBox();
            this.txbCadCPF = new System.Windows.Forms.MaskedTextBox();
            this.txbCadStatus = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txbCadEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbCadTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbCadNome
            // 
            resources.ApplyResources(this.txbCadNome, "txbCadNome");
            this.txbCadNome.Name = "txbCadNome";
            this.txbCadNome.Validating += new System.ComponentModel.CancelEventHandler(this.txbCadNome_Validating);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txbCadEndereço
            // 
            resources.ApplyResources(this.txbCadEndereço, "txbCadEndereço");
            this.txbCadEndereço.Name = "txbCadEndereço";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txbCadRegistro
            // 
            resources.ApplyResources(this.txbCadRegistro, "txbCadRegistro");
            this.txbCadRegistro.Name = "txbCadRegistro";
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // txbCadTelefone
            // 
            resources.ApplyResources(this.txbCadTelefone, "txbCadTelefone");
            this.txbCadTelefone.Name = "txbCadTelefone";
            // 
            // txbCadRG
            // 
            resources.ApplyResources(this.txbCadRG, "txbCadRG");
            this.txbCadRG.Name = "txbCadRG";
            // 
            // txbCadCPF
            // 
            resources.ApplyResources(this.txbCadCPF, "txbCadCPF");
            this.txbCadCPF.Name = "txbCadCPF";
            // 
            // txbCadStatus
            // 
            this.txbCadStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txbCadStatus.FormattingEnabled = true;
            this.txbCadStatus.Items.AddRange(new object[] {
            resources.GetString("txbCadStatus.Items"),
            resources.GetString("txbCadStatus.Items1"),
            resources.GetString("txbCadStatus.Items2"),
            resources.GetString("txbCadStatus.Items3"),
            resources.GetString("txbCadStatus.Items4"),
            resources.GetString("txbCadStatus.Items5")});
            resources.ApplyResources(this.txbCadStatus, "txbCadStatus");
            this.txbCadStatus.Name = "txbCadStatus";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txbCadEmail
            // 
            resources.ApplyResources(this.txbCadEmail, "txbCadEmail");
            this.txbCadEmail.Name = "txbCadEmail";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txbCadTelefone2
            // 
            resources.ApplyResources(this.txbCadTelefone2, "txbCadTelefone2");
            this.txbCadTelefone2.Name = "txbCadTelefone2";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Name = "label11";
            // 
            // FormCadastro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbCadTelefone2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbCadEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbCadStatus);
            this.Controls.Add(this.txbCadCPF);
            this.Controls.Add(this.txbCadRG);
            this.Controls.Add(this.txbCadTelefone);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbCadRegistro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCadEndereço);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbCadNome);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCadNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCadEndereço;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbCadRegistro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox txbCadTelefone;
        private System.Windows.Forms.MaskedTextBox txbCadRG;
        private System.Windows.Forms.MaskedTextBox txbCadCPF;
        private System.Windows.Forms.ComboBox txbCadStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txbCadEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txbCadTelefone2;
        private System.Windows.Forms.Label label11;
    }
}

