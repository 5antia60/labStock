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
    public partial class ConsultaDevoluções : Form
    {
        Conexão conexao = new Conexão();
        SqlConnection objConect = null;
        SqlCommand cmd = null;
        DataTable dt;
        SqlDataAdapter adpt;

        public ConsultaDevoluções(String Nivel)
        {
            InitializeComponent();

            if (Nivel.Equals("Monitor(a)") || Nivel.Equals("Professor(a)"))
            {
                groupBox2.Enabled = false;
            }
        }

        private void ConsultaDevoluções_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

        public void listaGrid()
        {
            string strSQL = "select * from tblDevoluções";

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
            txbObservação.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            txbPatrimônio.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            txbRegistro.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            txbResponsável.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbItem.Text = "";
            txbQuantidade.Text = "";
            txbData.Text = "";
            txbObservação.Text = "";
            txbPatrimônio.Text = "";
            txbRegistro.Text = "";
            txbResponsável.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            btnApagarLinha delLinha = new btnApagarLinha("tblDevoluções", txbID.Text, "ID");
            listaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterarLinhaTblDevoluções altLinha = new btnAlterarLinhaTblDevoluções(txbItem.Text, txbQuantidade.Text, txbData.Text, txbObservação.Text, txbPatrimônio.Text, txbRegistro.Text, txbResponsável.Text, txbID.Text);
            listaGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnAdicionarLinhaTblDevoluções addLinha = new btnAdicionarLinhaTblDevoluções(txbItem.Text, txbQuantidade.Text, txbData.Text, txbObservação.Text, txbPatrimônio.Text, txbRegistro.Text, txbResponsável.Text);
            listaGrid();
        }

        public void Pesquisa(string search, string col)
        {
            string query = "select * from tblDevoluções where " + col + " like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView.DataSource = dt;
            objConect.Close();
        }

        private void txbPesqItem_TextChanged(object sender, EventArgs e)
        {
            Pesquisa(txbPesqItem.Text, "Item");
        }

        private void txbPesqRegistro_TextChanged(object sender, EventArgs e)
        {
            Pesquisa(txbPesqRegistro.Text, "Registro");
        }
    }
}
