using LabEstoque.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.Apresentação
{
    public partial class ConsultaUsuarios : Form
    {
        Conexão conexao = new Conexão();
        SqlConnection objConect = null;
        SqlCommand cmd = null;
        DataTable dt;
        SqlDataAdapter adpt;

        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

        public void listaGrid()
        {
            string strSQL = "select * from tblLoginUsuarios";

            objConect = new SqlConnection(conexao.SConexao);
            cmd = new SqlCommand(strSQL, objConect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(cmd);
                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                dataGridView.DataSource = dtLista;
            }
            catch
            {
                MessageBox.Show("Erro ao conectar ao banco de dados...");
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txbNome.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txbTelefone.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txbRG.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txbCPF.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            txbEndereço.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            txbLogin.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            txbSenha.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();
            txbSstatus.Text = dataGridView.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbNome.Text = "";
            txbTelefone.Text = "";
            txbRG.Text = "";
            txbCPF.Text = "";
            txbEndereço.Text = "";
            txbLogin.Text = "";
            txbSenha.Text = "";
            txbSstatus.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            btnApagarLinha delLinha = new btnApagarLinha("tblLoginUsuarios", txbID.Text, "IdCliente");
            listaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterarLinhaTblLoginUsuarios altLinha = new btnAlterarLinhaTblLoginUsuarios(txbNome.Text, txbTelefone.Text, txbRG.Text, txbCPF.Text, txbEndereço.Text, txbLogin.Text, txbSenha.Text, txbSstatus.Text, txbID.Text);
            listaGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnAdicionarLinhaTblLoginUsuarios addLinha = new btnAdicionarLinhaTblLoginUsuarios(txbNome.Text, txbTelefone.Text, txbRG.Text, txbCPF.Text, txbEndereço.Text, txbLogin.Text, txbSenha.Text, txbSstatus.Text);
            listaGrid();
        }

        private void txbPesqNome_TextChanged(object sender, EventArgs e)
        {
            PesquisaNome(txbPesqNome.Text);
        }

        public void PesquisaNome(string search)
        {
            string query = "select * from tblLoginUsuarios where Nome like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView.DataSource = dt;
            objConect.Close();
        }

        private void txbPesqLogin_TextChanged(object sender, EventArgs e)
        {
            PesquisaLogin(txbPesqLogin.Text);
        }

        public void PesquisaLogin(string search)
        {
            string query = "select * from tblLoginUsuarios where Login like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView.DataSource = dt;
            objConect.Close();
        }
    }
}
