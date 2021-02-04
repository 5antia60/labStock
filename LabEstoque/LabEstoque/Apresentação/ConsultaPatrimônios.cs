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
    public partial class ConsultaPatrimônios : Form
    {
        Conexão conexao = new Conexão();
        SqlConnection objConect = null;
        SqlCommand cmd = null;
        DataTable dt;
        SqlDataAdapter adpt;

        public ConsultaPatrimônios(String Nivel)
        {
            InitializeComponent();

            if (Nivel.Equals("Monitor(a)") || Nivel.Equals("Professor(a)") || Nivel.Equals("Estagiário(a)"))
            {
                groupBox2.Enabled = false;
            }
        }

        private void ConsultaPatrimônios_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

        public void listaGrid()
        {
            string strSQL = "select * from tblPatrimônio2";

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txbSituação_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txbItem.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txbCodigo.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txbPatrimônio.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txbSituação.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbItem.Text = "";
            txbPatrimônio.Text = "";
            txbSituação.Text = "";
            txbCodigo.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            btnApagarLinha delLinha = new btnApagarLinha("tblPatrimônio2", txbID.Text, "ID");
            listaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterarLinhaTblPatrimônio altLinha = new btnAlterarLinhaTblPatrimônio(txbItem.Text, txbCodigo.Text, txbPatrimônio.Text, txbSituação.Text, txbID.Text);
            listaGrid();
        }

        private void txbPesqItem_TextChanged(object sender, EventArgs e)
        {

        }

        public void Pesquisa(string search)
        {
            string query = "select * from tblPatrimônio2 where "+ txbCol.Text +" like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView.DataSource = dt;
            objConect.Close();
        }

        private void txbPesqPatrimônio_TextChanged(object sender, EventArgs e)
        {
            Pesquisa(txbPesq.Text);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            btnAdicionarLinhaTblPatrimônio addLinha = new btnAdicionarLinhaTblPatrimônio(txbItem.Text, txbCodigo.Text, txbPatrimônio.Text, txbSituação.Text);
            listaGrid();
        }
    }
}
