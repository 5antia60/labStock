using LabEstoque.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.Apresentação
{
    public partial class tblPatrimônio : Form
    {
        public string value { get; set; }
        Conexão conexao = new Conexão();
        DataTable dt;
        SqlDataAdapter adpt;
        FormEmpréstimo FE = new FormEmpréstimo();
        Manutencao MA = new Manutencao();

        public tblPatrimônio()
        {
            InitializeComponent();   
        }

        public void PEmprestimo(FormEmpréstimo frm1)
        {
            FE = frm1;//atribuo a instancia recebida pelo construtor a minha variavel interna
            //associo o mesmo texto do tbxTextBoxFormA ao meu FORM B

            txbEscPatrimônio.Text = FE.txbEmpPatrimônio.Text.ToString();
        }

        public void PManutencao(Manutencao frm1)
        {
            MA = frm1;

            txbEscPatrimônio.Text = MA.txbPatrimonio.Text.ToString();
        }

        private void tblPatrimônio_Load(object sender, EventArgs e)
        {
            Pesquisa(value);
        }

        public void Pesquisa(string search)
        {
            string query = "select * from tblPatrimônio2 where Código like '%"+ search +"%' and Situação not like 'Emprestado'";
            adpt = new SqlDataAdapter(query, conexao.SConexao);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //passo para a textbox do FORM A o mesmo texto que está na minha do FORM B

            FE.txbEmpPatrimônio.Text = txbEscPatrimônio.Text.ToString();
            FE.txbEmpPatrimônio.Refresh(); //recarrego ela
            MA.txbPatrimonio.Text = txbEscPatrimônio.Text.ToString();
            MA.txbPatrimonio.Refresh();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbEscPatrimônio.Text = (string)dataGridView1.CurrentRow.Cells[3].Value;
        }
    }
}
