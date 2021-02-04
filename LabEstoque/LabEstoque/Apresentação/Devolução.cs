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

namespace LabEstoque
{
    public partial class FormDevolução : Form
    {
        Conexão conexao = new Conexão();

        DataTable dtt = new DataTable();
        DataTable dt;
        SqlDataAdapter adpt;
        public int i;
        string ID1;
        string Item1;
        string Patrimônio1;
        string Quantidade1;
        string Observação1;

        public FormDevolução()
        {
            InitializeComponent();
        }

        public void PesquisaItem(string search)
        {
            string query = "select * from tblEmpréstimos where "+ txbPesqCol.Text +" like '%" + search + "%' and Itens_para_devolver != '0'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FormDevolução_Load(object sender, EventArgs e)
        {
            dtt.Columns.Add("ID");
            dtt.Columns.Add("Item");
            dtt.Columns.Add("Quantidade");
            dtt.Columns.Add("Observação");
            dtt.Columns.Add("Patrimônio");

            string query = "select * from tblEmpréstimos where Itens_para_devolver != '0'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDevolver_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine(dataGridView1.CurrentRow.Cells[1].Value);

            ControleRegistro controle = new ControleRegistro();
            controle.acessar(txbDevRegistro.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    for (i = 0; i < dgItensDevolver.Rows.Count; i++)
                    {
                        object valorID = dgItensDevolver.Rows[i].Cells["ID"].Value;
                        ID1 = (string)valorID;

                        object valorItem = dgItensDevolver.Rows[i].Cells["Item"].Value;
                        Item1 = (string)valorItem;

                        object valorQuantidade = dgItensDevolver.Rows[i].Cells["Quantidade"].Value;
                        Quantidade1 = (string)valorQuantidade;

                        object valorObservação = dgItensDevolver.Rows[i].Cells["Observação"].Value;
                        Observação1 = (string)valorObservação;

                        object valorPatrimônio = dgItensDevolver.Rows[i].Cells["Patrimônio"].Value;
                        Patrimônio1 = (string)valorPatrimônio;

                        Devolução cad = new Devolução(Item1, Quantidade1, txbDevData.Text, Observação1, Patrimônio1, txbDevRegistro.Text, txbDevResponsavel.Text, txbDevID.Text, ID1);

                        if (i == dgItensDevolver.Rows.Count - 1)
                        {
                            MessageBox.Show(cad.mensagem);
                            if (cad.mensagem == "Item devolvido com Sucesso...")
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

        private void txbDevData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txbDevSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txbDevIDCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txbDevPatrimonio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbDevObservação_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbDevQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbDevItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PesquisaItem(txbDevPItem.Text);
        }

        private void txbDevPRegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDevAdicionar_Click(object sender, EventArgs e)
        {
            string ID = txbDevID.Text;
            string Item = txbDevItem.Text;
            decimal Quantidade = decimal.Parse(txbDevQuantidade.Text);
            string Observação = txbDevObservação.Text;
            string Patrimônio = txbDevPatrimonio.Text;
            
            if (Item == "" || Quantidade == 0)
            {
                MessageBox.Show("Escolha produto e quantidade para adicionar");
            }
            else if(Patrimônio != "" && Quantidade != 1)
            {
                MessageBox.Show("Itens com patrimônio devem ser devolvidos um de cada vez");
            }
            else
            {
                dtt.Rows.Add(ID, Item, Quantidade, Observação, Patrimônio);
                dgItensDevolver.DataSource = dtt;
                txbDevID.Text = "";
                txbDevItem.Text = "";
                txbDevQuantidade.Text = "";
                txbDevObservação.Text = "";
                txbDevPatrimonio.Text = "";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbDevItem.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txbDevQuantidade.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txbDevPatrimonio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txbDevID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txbDevRegistro.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
