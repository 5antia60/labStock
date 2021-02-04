using Sistema_Pesenca_Alunos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.Apresentação
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(String Nivel, String Nome)
        {
            InitializeComponent();

            TelaConsultaInicial LoginDAO = new TelaConsultaInicial();

            lblNome.Text = LoginDAO.nome(Nome);
            lblNivel.Text = Nivel;

            if (Nivel.Equals("Monitor(a)") || Nivel.Equals("Estagiário(a)") || Nivel.Equals("Professor(a)"))
            {
                tsUsuários.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroConsulta CC = new CadastroConsulta();
            CC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginConsulta_Load(object sender, EventArgs e)
        {

        }

        private void emprestarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpréstimo FE = new FormEmpréstimo();
            FE.Show();
        }

        private void dsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastro C = new FormCadastro();
            C.Show();
        }

        private void devolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDevolução FD = new FormDevolução();
            FD.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientes CC = new ConsultaClientes(lblNivel.Text);
            CC.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEstoque CE = new ConsultaEstoque(lblNivel.Text);
            CE.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void tsUsuários_Click(object sender, EventArgs e)
        {
            ConsultaUsuarios CU = new ConsultaUsuarios();
            CU.Show();
        }

        private void itensComPatrimônioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPatrimônios CP = new ConsultaPatrimônios(lblNivel.Text);
            CP.Show();
        }

        private void empréstimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEmpréstimos CE = new ConsultaEmpréstimos(lblNivel.Text);
            CE.Show();
        }

        private void devoluçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDevoluções CD = new ConsultaDevoluções(lblNivel.Text);
            CD.Show();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormCadastro bv = new FormCadastro();
            bv.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormEmpréstimo bv = new FormEmpréstimo();
            bv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDevolução bv = new FormDevolução();
            bv.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tela_Inicial TI = new Tela_Inicial(lblNivel.Text);
            TI.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Manutencao MA = new Manutencao();
            MA.Show();
        }

        private void manutençõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaManutenção CM = new ConsultaManutenção(lblNivel.Text);
            CM.Show();
        }
    }
}
