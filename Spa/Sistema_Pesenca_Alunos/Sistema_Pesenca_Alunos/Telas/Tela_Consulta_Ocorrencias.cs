using Sistema_Pesenca_Alunos.Modelo;
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

namespace Sistema_Pesenca_Alunos.Telas
{
    public partial class Tela_Consulta_Ocorrencias : Form
    {
        SqlConnection objConect = null;
        SqlCommand cmd = null;
        Conexao conexao = new Conexao();
        DataTable dt;
        SqlDataAdapter adpt;

        public Tela_Consulta_Ocorrencias()
        {
            InitializeComponent();
        }

        private void Tela_Consulta_Ocorrencias_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

        public void listaGrid()
        {
            string strSQL = "select * from Dados_Ocorrencia";

            objConect = new SqlConnection(conexao.SConexao);
            cmd = new SqlCommand(strSQL, objConect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(cmd);
                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                Historico.DataSource = dtLista;
            }
            catch
            {
                MessageBox.Show("Erro ao conectar ao banco de dados...");
            }
        }

        public void Pesquisa(string search)
        {
            string query = "select * from Dados_Ocorrencia where " + txbCol.Text + " like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            Historico.DataSource = dt;
            objConect.Close();
        }

        private void txbPesq_TextChanged(object sender, EventArgs e)
        {
            Pesquisa(txbPesq.Text);
        }
    }
}
