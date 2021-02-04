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
    public partial class ConsultaEmpréstimos : Form
    {
        Conexão conexao = new Conexão();
        SqlConnection objConect = null;
        SqlCommand cmd = null;
        DataTable dt;
        SqlDataAdapter adpt;

        public ConsultaEmpréstimos(String Nivel)
        {
            InitializeComponent();

            if (Nivel.Equals("Monitor(a)") || Nivel.Equals("Professor(a)"))
            {
                groupBox2.Enabled = false;
            }
        }

        private void ConsultaEmpréstimos_Load(object sender, EventArgs e)
        {
           listaGrid();
        } 

        public void listaGrid()
        {
            string strSQL = "select * from tblEmpréstimos";

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
            txbItem.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txbQuantidade.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txbData.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txbPatrimônio.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            txbDataPDevolver.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            txbRegistro.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            txbSetorMatéria.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();
            txbResponsável.Text = dataGridView.CurrentRow.Cells[8].Value.ToString();
            txbItensPDevolver.Text = dataGridView.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbItem.Text = "";
            txbQuantidade.Text = "";
            txbData.Text = "";
            txbPatrimônio.Text = "";
            txbDataPDevolver.Text = "";
            txbRegistro.Text = "";
            txbSetorMatéria.Text = "";
            txbResponsável.Text = "";
            txbItensPDevolver.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            btnApagarLinha delLinha = new btnApagarLinha("tblEmpréstimos", txbID.Text, "ID");
            listaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterarLinhaTblEmpréstimos altLinha = new btnAlterarLinhaTblEmpréstimos(txbItem.Text, txbQuantidade.Text, txbData.Text, txbPatrimônio.Text, txbDataPDevolver.Text, txbRegistro.Text, txbSetorMatéria.Text, txbResponsável.Text, txbItensPDevolver.Text, txbID.Text);
            listaGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnAdicionarLinhaTblEmpréstimos addLinha = new btnAdicionarLinhaTblEmpréstimos(txbItem.Text, txbQuantidade.Text, txbData.Text, txbPatrimônio.Text, txbDataPDevolver.Text, txbRegistro.Text, txbSetorMatéria.Text, txbResponsável.Text, txbItensPDevolver.Text);
            listaGrid();
        }

        private void txbPesqItem_TextChanged(object sender, EventArgs e)
        {
            Pesquisa(txbPesqItem.Text, "Item");
        }

        public void Pesquisa(string search, string col)
        {
            string query = "select * from tblEmpréstimos where "+ col +" like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView.DataSource = dt;
            objConect.Close();
        }

        private void txbPesqRegistro_TextChanged(object sender, EventArgs e)
        {
            Pesquisa(txbPesqRegistro.Text, "Registro");
        }

        private void txbPesqData_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
