using LabEstoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            if (txbCadCPF.MaskCompleted == true && txbCadRG.MaskCompleted == true && txbCadTelefone.MaskCompleted == true)
            {
                Cadastro cad = new Cadastro(txbCadNome.Text, txbCadRG.Text, txbCadCPF.Text, txbCadEndereço.Text, txbCadStatus.Text, txbCadTelefone.Text, txbCadRegistro.Text, txbCadTelefone2.Text, txbCadEmail.Text);
                MessageBox.Show(cad.mensagem);

                if (cad.mensagem == "Cadastrado com Sucesso...")
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha o CPF, RG ou Telefone corretamente...");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txbCadNome_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
