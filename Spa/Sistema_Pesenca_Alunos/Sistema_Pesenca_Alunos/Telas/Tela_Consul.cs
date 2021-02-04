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
    public partial class Tela_Consul : Form
    {
        SqlConnection objConect = null;
        SqlCommand cmd = null;
        Conexao conexao = new Conexao();
        DataTable dt;
        SqlDataAdapter adpt;

        public Tela_Consul()
        {
            InitializeComponent();
        }

        public void listaGrid()
        {
            string strSQL = "select * from Dados_Presenca";

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbCodProf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tela_Consul_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Pesquisa(txbPesq.Text);
        }

        public void Pesquisa(string search)
        {
            string query = "select * from Dados_Presenca where " + txbCol.Text + " like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            Historico.DataSource = dt;
            objConect.Close();
        }

        private void txbPesqHD_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void PesquisaData(string search)
        {

        }

        private void txbData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
