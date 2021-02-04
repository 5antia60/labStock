using Sistema_Pesenca_Alunos.Modelo;
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
    public partial class Tela_Baixa_Alunos : Form
    {
        public String cod="";
        public Tela_Baixa_Alunos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Historico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Consul_Dados_Exp(txbRA.Text, DTPDataInicio.Value, DTPDataFim.Value);
            Historico.DataSource = controle.Dados;

            Historico.Columns[0].HeaderText = "Codigo da Reserva";
            Historico.Columns[1].HeaderText = "Código Aluno";
            Historico.Columns[2].HeaderText = "Nome do Aluno";            
            Historico.Columns[3].HeaderText = "Experimento";
            Historico.Columns[4].HeaderText = "Data";
        }

        private void Tela_Baixa_Alunos_Load(object sender, EventArgs e)
        {

        }

        private void btInserir_Click(object sender, EventArgs e)
        {                 
            try
            {
                cod = Convert.ToString(Historico.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Faça a pesquisa e selecione uma linha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            Controle controle = new Controle();
            controle.ModificDados_ExpSaida(cod, txbhora.Text,txbminutos.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                cod = Convert.ToString(Historico.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Faça a pesquisa e selecione uma linha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Controle controle = new Controle();
            controle.ModificDados_ExpEntrada(cod, txbhora.Text, txbminutos.Text);
        }
    }
}
