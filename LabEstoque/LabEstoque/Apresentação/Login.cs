using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.Apresentação
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txbSenha.Text != "admlabeletrica")
            {
                ControleLogin controle = new ControleLogin();
                controle.acessar(txbLogin.Text, txbSenha.Text);
                if (controle.mensagem.Equals(""))
                {

                    if (controle.tem)
                    {
                        MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MenuPrincipal bv = new MenuPrincipal(controle.Nivel, txbLogin.Text);
                        this.Hide();
                        bv.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(controle.mensagem);
                }
            }
            else
            {
                MenuPrincipal nt = new MenuPrincipal("Administrador", "ADM");
                nt.Show();
                this.Hide();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroConsulta CC = new CadastroConsulta();
            CC.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
