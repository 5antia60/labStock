using Sistema_Pesenca_Alunos.DAL;
using Sistema_Pesenca_Alunos.Modelo;
using Sistema_Pesenca_Alunos.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Pesenca_Alunos
{
    public partial class Tela_Inicial : Form
    {
        ChamaTelas Chamado = new ChamaTelas( );
        public String nivel= "";
        public Tela_Inicial(String Nivel)
        {
            InitializeComponent();

            nivel = Nivel;

            if(Nivel.Equals("Estagiario(a)") || Nivel.Equals("Monitor(a)"))
            {
                //Nivel de acesso
            }
            else
            {
                //Nivel de acesso
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            controle.Checar(txbRA.Text, txbCodProf.Text, txbCodAux.Text, txbTurma.Text, nivel);

            if(controle.tem == true)
            {
                if (controle.adicionarPresenca(txbCodProf.Text, txbTempProf.Text + "°", txbCodAux.Text, txbTempAux.Text + "°", txbRA.Text, txbTempAluno.Text, txbTurma.Text, txbObservacao.Text) == true)
                {
                    MessageBox.Show("Usuario Registrado - Bem-vindo", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbRA.Text = "";
                    txbTempAluno.Text = "";
                }
                else
                {
                    if (!controle.mensagem.Equals(""))
                    {
                        MessageBox.Show(controle.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } 
        }

        private void Tela_Inicial_Load(object sender, EventArgs e)
        {

        }

        private void txbCodProf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void enviarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Tsmi_Chamado_Click(object sender, EventArgs e)
        {
            
        }

        private void Tsmi_Consulta_Click(object sender, EventArgs e)
        {
            
        }

        private void tsCad_aluno_Click(object sender, EventArgs e)
        {

        }

        private void tsCad_Aux_Click(object sender, EventArgs e)
        {

        }

        private void tsCad_Prof_Click(object sender, EventArgs e)
        {

        }

        private void tsCad_Turma_Click(object sender, EventArgs e)
        {
            Chamado.Cad_Turma();
        }

        private void reservaExperimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void presençasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chamado.Consulta();
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chamado.Reseva_Exp();
        }

        private void consultarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chamado.Consult_Reserv_Exp();
        }

        private void experimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chamado.Cod_Exp();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Inicial_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void registrarSaidaAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chamado.Update_Hora_Saida();
        }

        private void consultaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void ocorrênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Consulta_Ocorrencias TCO = new Tela_Consulta_Ocorrencias();
            TCO.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Cad_Clientes TCC = new Tela_Cad_Clientes();
            TCC.Show();
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_Consulta_Turmas TCT = new Tela_Consulta_Turmas();
            TCT.Show();
        }

        private void ocorrênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chamado.Ocorrencia(nivel);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
