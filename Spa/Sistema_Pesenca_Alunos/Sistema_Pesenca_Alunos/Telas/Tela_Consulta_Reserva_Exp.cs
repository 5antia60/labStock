using Sistema_Pesenca_Alunos.DAL;
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
    public partial class Tela_Consulta_Reserva_Exp : Form
    {
        SqlConnection objConect = null;
        SqlCommand cmd = null;
        Conexao conexao = new Conexao();
        DataTable dt;
        SqlDataAdapter adpt;

        public Tela_Consulta_Reserva_Exp()
        {
            InitializeComponent();          
        }

        public void listaGrid()
        {
            string strSQL = "select * from Reserva_Experimentos";

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
            string query = "select * from Reserva_Experimentos where " + txbCol.Text + " like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            Historico.DataSource = dt;
            objConect.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Consulta_Reserva_Exp_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void cbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btInserir_Click(object sender, EventArgs e)
        {

        }

        private void cbExperimento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Historico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DTPDataFim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DTPDataInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbPesq_TextChanged(object sender, EventArgs e)
        {
            Pesquisa(txbPesq.Text);
        }

        private void Historico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = Historico.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnApagarLinha delLinha = new btnApagarLinha("Reserva_Experimentos", txbID.Text, "ID");
            listaGrid();
            txbID.Text = "";
        }
    }
}
