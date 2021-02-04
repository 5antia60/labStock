using LabEstoque.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.Apresentação
{
    public partial class ConsultaClientes : Form
    {
        Conexão conexao = new Conexão();
        SqlConnection objConect = null;
        SqlCommand cmd = null;
        DataTable dt;
        SqlDataAdapter adpt;
        string Nivel = "";


        public ConsultaClientes(String Nivel)
        {
            InitializeComponent();

            if(Nivel.Equals("Monitor(a)") || Nivel.Equals("Professor(a)"))
            {
                groupBox2.Enabled = false;
            }
        }

        public void listaGrid()
        {
            string strSQL = "select * from tblRegistro";

            objConect = new SqlConnection(conexao.SConexao);
            cmd = new SqlCommand(strSQL,objConect);

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
        
        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void Pesquisa(string search)
        {
            string query = "select * from tblRegistro where Nome like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView.DataSource = dt;
            objConect.Close();
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisa(txbPesquisaNome.Text);
        }

        private void txbColuna_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txbPesquisaRegistro_TextChanged(object sender, EventArgs e)
        {
            PesquisaRegistro(txbPesquisaRegistro.Text);
        }
        public void PesquisaRegistro(string search)
        {
            string query = "select * from tblRegistro where Registro like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView.DataSource = dt;
            objConect.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbNome.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txbRG.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txbEmail.Text = dataGridView.CurrentRow.Cells[9].Value.ToString();
            txbStatus.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            txbTelefone.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            txbCPF.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txbEndereço.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            txbRegistro.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();
            txbTelefone2.Text = dataGridView.CurrentRow.Cells[8].Value.ToString();
            txbID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnAdicionarLinhaTblRegistro addLinha = new btnAdicionarLinhaTblRegistro(txbNome.Text, txbRG.Text, txbCPF.Text, txbEndereço.Text, txbStatus.Text, txbTelefone.Text, txbRegistro.Text, txbTelefone2.Text, txbEmail.Text);
            listaGrid();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            btnApagarLinha delLinha = new btnApagarLinha ("tblRegistro", txbID.Text, "IdCliente");
            listaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterarLinhaTblRegistro altLinha = new btnAlterarLinhaTblRegistro(txbNome.Text, txbRG.Text, txbCPF.Text, txbEndereço.Text, txbStatus.Text, txbTelefone.Text, txbRegistro.Text, txbTelefone2.Text, txbEmail.Text, txbID.Text);
            listaGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
            txbRG.Text = "";
            txbEmail.Text = "";
            txbStatus.Text = "";
            txbTelefone.Text = "";
            txbCPF.Text = "";
            txbEndereço.Text = "";
            txbRegistro.Text = "";
            txbTelefone2.Text = "";
            txbID.Text = "";
        }
    }
}
