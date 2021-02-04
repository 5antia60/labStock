using Sistema_Pesenca_Alunos.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Pesenca_Alunos.Telas
{
    public partial class Tela_Cad_Clientes : Form
    {
        public Tela_Cad_Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbCPF.MaskCompleted == true && txbRG.MaskCompleted == true && txbTelefone.MaskCompleted == true)
            {
                NovoCliente NC = new NovoCliente(txbNome.Text, txbRG.Text, txbCPF.Text, txbEndereco.Text, txbStatus.Text, txbTelefone.Text, txbRegistro.Text, txbTelefone2.Text, txbEmail.Text);
                MessageBox.Show(NC.mensagem);

                if (NC.mensagem == "Cadastrado com Sucesso...")
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha o CPF, RG ou Telefone corretamente...");
            }
        }
    }
}
