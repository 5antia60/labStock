using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque
{
    public partial class CadastroConsulta : Form
    {
        public CadastroConsulta()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbCadCPF.MaskCompleted == true && txbCadRG.MaskCompleted == true && txbCadTelefone.MaskCompleted == true)
            {
                if (txbCadStatus.Text == "Monitor(a)" || txbCadStatus.Text == "Estagiário(a)" || txbCadStatus.Text == "Professor(a)" || txbCadStatus.Text == "Coordenador(a)" || txbCadStatus.Text == "Administrador(a)")
                {
                    ControleLogin controle = new ControleLogin();
                    String mensagem = controle.cadastrar(txbCadNome.Text, txbCadTelefone.Text, Convert.ToString(txbCadRG.Text), txbCadCPF.Text, txbCadEnd.Text, txbCadLogin.Text, txbCadSenha.Text, txbCadConfSenha.Text, txbCadStatus.Text);
                    if (controle.tem) //mensagem de sucesso
                    {
                        MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(controle.mensagem); //mensagem de erro
                    }
                }
                else
                {
                    MessageBox.Show("Escolha um status valido...");
                }
            }
            else
            {
                MessageBox.Show("Preencha o CPF, RG ou Telefone corretamente...");
            }
        }

        private void CadastroConsulta_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
