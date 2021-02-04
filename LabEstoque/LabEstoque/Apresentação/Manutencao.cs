using LabEstoque.Modelo;
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
    public partial class Manutencao : Form
    {
        Conexão conexao = new Conexão();
        SqlConnection objConect = null;
        SqlCommand cmd = null;
        DataTable dt;
        SqlDataAdapter adpt;

        public Manutencao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tblPatrimônio tblPatrimonio = new tblPatrimônio();
            tblPatrimonio.PManutencao(this);
            tblPatrimonio.value = txbDescricao.Text;
            tblPatrimonio.Show();
        }

        private void txbPesqLinha_TextChanged(object sender, EventArgs e)
        {
            Pesquisa(txbPesqLinha.Text);
        }

        public void Pesquisa(string search)
        {
            string query = "select ID, Item, Quantidade_Total, Quantidade_Atual, Descrição, Sala, Armário, Espécie, Classificação from tblEstoque2 where " + txbPesqCol.Text + " like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            datagridview1.DataSource = dt;
            objConect.Close();
        }

        private void Manutencao_Load(object sender, EventArgs e)
        {
            listaGrid1();
            listaGrid2();
        }

        public void listaGrid2()
        {
            string strSQL = "SELECT ID, Item, Patrimônio, Ocorrência, Registro, Data, Observação FROM tblManutenção WHERE Ocorrência != 'Item consertado'";

            objConect = new SqlConnection(conexao.SConexao);
            cmd = new SqlCommand(strSQL, objConect);

            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(cmd);
                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                dataGridView2.DataSource = dtLista;
            }
            catch
            {
                MessageBox.Show("Erro ao conectar ao banco de dados...");
            }
        }

        public void listaGrid1()
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

        private void datagridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = datagridview1.CurrentRow.Cells[0].Value.ToString();
            txbItem.Text = datagridview1.CurrentRow.Cells[1].Value.ToString();
            txbDescricao.Text = datagridview1.CurrentRow.Cells[4].Value.ToString();
            txbEspecie.Text = datagridview1.CurrentRow.Cells[7].Value.ToString();

            txbPatrimonio.Text = "";
            txbOcorrencia.Text = "Item quebrado";

            txbItem.Enabled = true;
            txbPatrimonio.Enabled = true;
            txbData.Enabled = true;
            txbObservacao.Enabled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txbItem.Text == "")
            {
                MessageBox.Show("Escolha produto para continuar");
            }
            else if (txbEspecie.Text == "2" && txbPatrimonio.Text == "")
            {
                MessageBox.Show("Busque um patrimônio");
            }
            else if (txbEspecie.Text != "2" && txbPatrimonio.Text != "")
            {
                MessageBox.Show("O item selecionado não possui um patrimônio... Esvazie o campo 'patrimônio'");
            }
            else if (txbEspecie.Text == "2" && txbPatrimonio.Text != "" || txbEspecie.Text != "2" && txbPatrimonio.Text == "")
            {
                ControleRegistro controle = new ControleRegistro();
                controle.acessar(txbRegistro.Text);
                if (controle.mensagem.Equals(""))
                {
                    if (controle.tem)
                    {
                        Manutenção MA = new Manutenção(txbItem.Text, txbPatrimonio.Text, txbOcorrencia.Text, txbRegistro.Text, txbData.Text, txbObservacao.Text, txbID.Text);
                        MessageBox.Show(MA.mensagem);
                        if (MA.mensagem == "Ocorrência registrada com sucesso...")
                        {
                            this.Close();
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
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txbItem.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txbPatrimonio.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();

            txbEspecie.Text = "2";
            txbDescricao.Text = "";

            txbItem.Enabled = false;
            txbPatrimonio.Enabled = false;
            txbData.Enabled = false;
            txbObservacao.Enabled = false;
            txbOcorrencia.Text = "Item consertado";
        }
    }
}
