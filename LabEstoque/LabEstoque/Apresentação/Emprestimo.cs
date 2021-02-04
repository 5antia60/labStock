using LabEstoque.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;
using LabEstoque.Apresentação;
using System.Drawing.Imaging;

namespace LabEstoque
{
    public partial class FormEmpréstimo : Form
    {
        Conexão conexao = new Conexão();
        DataTable dt;
        SqlDataAdapter adpt;
        DataTable dtt = new DataTable();
        SqlConnection objConect = null;
        SqlCommand cmd = null;
        public int i;
        string ID;
        string Item1;
        string Patrimônio1;
        string Quantidade1;

        public FormEmpréstimo()
        {
            InitializeComponent();
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

                dataGridView1.DataSource = dtLista;
            }
            catch
            {
                MessageBox.Show("Erro ao conectar ao banco de dados...");
            }
        }

        public void Pesquisa(string search)
        {
            string query = "select ID, Item, Quantidade_Total, Quantidade_Atual, Descrição, Sala, Armário, Espécie, Classificação from tblEstoque2 where Item like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaGrid();
            lblFotoNull.Hide();

            dtt.Columns.Add("Item");
            dtt.Columns.Add("Patrimônio");
            dtt.Columns.Add("Quantidade");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void btnEmprestar_Click(object sender, EventArgs e)
        {
            ControleRegistro controle = new ControleRegistro();
            controle.acessar(txbEmpRegistro.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    for (i = 0; i < dgItensEmprestar.Rows.Count; i++)
                    {
                        object valorItem = dgItensEmprestar.Rows[i].Cells["Item"].Value;
                        Item1 = (string)valorItem;

                        object valorPatrimônio = dgItensEmprestar.Rows[i].Cells["Patrimônio"].Value;
                        Patrimônio1 = (string)valorPatrimônio;

                        object valorQuantidade = dgItensEmprestar.Rows[i].Cells["Quantidade"].Value;
                        Quantidade1 = (string)valorQuantidade;

                        Empréstimo cad = new Empréstimo(Item1, Quantidade1, txbEmpData.Text, Patrimônio1, txbEmpDevolução.Text, txbEmpRegistro.Text, txbEmpResponsavel.Text, txbEmpSetorMateria.Text);
                        
                        if(i == dgItensEmprestar.Rows.Count - 1)
                        {
                            MessageBox.Show(cad.mensagem);
                            if (cad.mensagem == "Item emprestado com Sucesso...")
                            {
                                this.Close();
                            }
                        }
                    }                   
                }
                else
                {
                    MessageBox.Show("Registro não encontrado, vá para o cadastro", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void txbEmpRegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbEmpDevolução_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txbEmpData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txbEmpPatrimônio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbEmpQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbEmpPesquisa_TextChanged(object sender, EventArgs e)
        {
            Pesquisa(txbEmpPesquisa.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbEmpItem.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txbEmpEspécie.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txbDescricao.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Console.WriteLine(ID);

            try
            {
                string sql = "SELECT Foto FROM tblEstoque2 WHERE ID = '" + ID + "' and Foto IS not null";
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

        public void btnADD_Click(object sender, EventArgs e)
        {
            if (txbEmpQuantidade.Text != "")
            {
                string Item = txbEmpItem.Text;
                string Patrimônio = txbEmpPatrimônio.Text;
                decimal Quantidade = decimal.Parse(txbEmpQuantidade.Text);

                if (Item == "" || Quantidade == 0)
                {
                    MessageBox.Show("Escolha produto e quantidade para adicionar");
                }
                else if (txbEmpEspécie.Text == "2" && txbEmpQuantidade.Text != "1")
                {
                    MessageBox.Show("Itens com patrimônio precisam ser escolhidos um por vez");
                }
                else if (txbEmpEspécie.Text == "2" && txbEmpPatrimônio.Text == "")
                {
                    MessageBox.Show("Busque um patrimônio");
                }
                else if (txbEmpEspécie.Text != "2" && txbEmpPatrimônio.Text != "")
                {
                    MessageBox.Show("O item selecionado não possui um patrimônio... Esvazie o campo 'patrimônio'");
                }
                else if (txbEmpEspécie.Text == "2" && txbEmpPatrimônio.Text != "" || txbEmpEspécie.Text != "2" && txbEmpPatrimônio.Text == "")
                {
                    dtt.Rows.Add(Item, Patrimônio, Quantidade);
                    dgItensEmprestar.DataSource = dtt;
                    txbEmpItem.Text = "";
                    txbEmpPatrimônio.Text = "";
                    txbEmpQuantidade.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Escolha uma quantidade");
            }
        }

        private void dgItensEmprestar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPatrimônio_Click(object sender, EventArgs e)
        {
            tblPatrimônio tblPatrimonio = new tblPatrimônio();
            tblPatrimonio.PEmprestimo(this);
            tblPatrimonio.value = txbDescricao.Text;
            tblPatrimonio.Show();
        }

        private void btnAmpliarImg_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                MostrarFoto MF = new MostrarFoto(ID);
                MF.Show();
            }
            else
            {
                MessageBox.Show("Nenhuma imagem selecionada para ampliar");
            }
        }
    }
}
