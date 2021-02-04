using LabEstoque.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.Apresentação
{
    public partial class ConsultaEstoque : Form
    {
        Conexão conexao = new Conexão();
        SqlConnection objConect = null;
        SqlCommand cmd = null;
        DataTable dt;
        SqlDataAdapter adpt;
        string imgLoc = "";

        public ConsultaEstoque(String Nivel)
        {
            InitializeComponent();

            if (Nivel.Equals("Monitor(a)") || Nivel.Equals("Professor(a)") || Nivel.Equals("Estagiário(a)"))
            {
                btnInserir.Enabled = false;
                btnSalvarImg.Enabled = false;
                btnApagarImg.Enabled = false;
                groupBox2.Enabled = false;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void listaGrid()
        {
            string strSQL = "select ID, Item, Quantidade_Total, Quantidade_Atual, Descrição, Sala, Armário, Espécie, Classificação from tblEstoque2";

            objConect = new SqlConnection(conexao.SConexao);
            cmd = new SqlCommand(strSQL, objConect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(cmd);
                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                datagridview1.DataSource = dtLista;
            }
            catch
            {
                MessageBox.Show("Erro ao conectar ao banco de dados...");
            }
        }

        private void ConsultaEstoque_Load(object sender, EventArgs e)
        {
            listaGrid();
            lblFotoNull.Hide();
        }

        public void Pesquisa(string search)
        {
            string query = "select ID, Item, Quantidade_Total, Quantidade_Atual, Descrição, Sala, Armário, Espécie, Classificação from tblEstoque2 where " + txbPesqColuna.Text+" like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            datagridview1.DataSource = dt;
            objConect.Close();
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisa(txbPesquisa.Text);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = datagridview1.CurrentRow.Cells[0].Value.ToString();
            txbItem.Text = datagridview1.CurrentRow.Cells[1].Value.ToString();
            txbQntTotal.Text = datagridview1.CurrentRow.Cells[2].Value.ToString();
            txbQntAtual.Text = datagridview1.CurrentRow.Cells[3].Value.ToString();
            txbDescrição.Text = datagridview1.CurrentRow.Cells[4].Value.ToString();
            txbSala.Text = datagridview1.CurrentRow.Cells[5].Value.ToString();
            txbArmario.Text = datagridview1.CurrentRow.Cells[6].Value.ToString();
            txbEspecie.Text = datagridview1.CurrentRow.Cells[7].Value.ToString();
            txbClassificacao.Text = datagridview1.CurrentRow.Cells[8].Value.ToString();

            try
            {
                string sql = "SELECT Foto FROM tblEstoque2 WHERE ID = '"+ txbID.Text + "' and Foto IS not null";
                if (objConect.State != ConnectionState.Open)
                    objConect.Open();
                cmd = new SqlCommand(sql, objConect);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    lblFotoNull.Hide();
                    string img = (string)reader[0];
                    if (img == null)
                        pictureBox1.Image = null;
                    else
                    {
                        pictureBox1.ImageLocation = img;
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                    lblFotoNull.Show();
                }
                objConect.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao exibir a imagem");
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            btnApagarLinha delLinha = new btnApagarLinha("tblEstoque2", txbID.Text, "ID");
            listaGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbItem.Text = "";
            txbQntTotal.Text = "";
            txbQntAtual.Text = "";
            txbDescrição.Text = "";
            txbSala.Text = "";
            txbArmario.Text = "";
            txbEspecie.Text = "";
            txbClassificacao.Text = "";
            pictureBox1.Image = null;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterarLinhaTblEstoque altLinha = new btnAlterarLinhaTblEstoque(txbItem.Text, txbQntTotal.Text, txbQntAtual.Text, txbDescrição.Text, txbSala.Text, txbArmario.Text, txbEspecie.Text, txbClassificacao.Text, txbID.Text);
            listaGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txbEspecie.Text == "0" || txbEspecie.Text == "1" || txbEspecie.Text == "2")
            {
                btnAdicionarLinhaTblEstoque addLinha = new btnAdicionarLinhaTblEstoque(txbItem.Text, txbQntTotal.Text, txbQntAtual.Text, txbDescrição.Text, txbSala.Text, txbArmario.Text, txbEspecie.Text, txbClassificacao.Text);
                listaGrid();
            }
            else
            {
                MessageBox.Show("Escolha uma espécie válida");
            }
        }

        private void btnMostrarImg_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                MostrarFoto MF = new MostrarFoto(txbID.Text);
                MF.Show();
            }
            else
            {
                MessageBox.Show("Nenhuma imagem selecionada para ampliar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "All Files (*.*)|*.*";
                dlg.Title = "Selecione a foto do item";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    lblFotoNull.Hide();
                    imgLoc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imgLoc;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao buscar imagem");
            }
        }

        private void btnSalvarImg_Click(object sender, EventArgs e)
        {
            try
            {
                string img = pictureBox1.ImageLocation;
                string sql = "UPDATE tblEstoque2 SET Foto = @img WHERE ID = '" + txbID.Text + "'";
                if (objConect.State != ConnectionState.Open)
                    objConect.Open();
                cmd = new SqlCommand(sql, objConect);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                objConect.Close();
                if (x == 1)
                {
                    MessageBox.Show("Foto salva / atualizada");
                }
                else
                {
                    MessageBox.Show("Erro ao salvar / atualizar foto");
                }
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao salvar imagem");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnApagarImg_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE tblEstoque2 Set Foto = NULL where ID = @img";
            if (objConect.State != ConnectionState.Open)
                objConect.Open();
            cmd = new SqlCommand(sql, objConect);
            cmd.Parameters.Add(new SqlParameter("@img", txbID.Text));
            cmd.ExecuteNonQuery();
            objConect.Close();

            pictureBox1.Image = null;
            lblFotoNull.Show();
        }

        private void txbPesqColuna_TextUpdate(object sender, EventArgs e)
        {
        }

        private void lblFotoNull_Click(object sender, EventArgs e)
        {

        }
    }
}
