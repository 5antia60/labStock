using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.Apresentação
{
    public partial class MostrarFoto : Form
    {
        Conexão conexao = new Conexão();
        SqlConnection objConect = null;
        SqlCommand cmd = null;
        ConsultaEstoque CE = new ConsultaEstoque("Administrador(a)");
        string IDCE = "";

        public MostrarFoto(String ID)
        {
            InitializeComponent();
            objConect = new SqlConnection(conexao.SConexao);
            IDCE = ID;
        }

        private void MostrarFoto_Load(object sender, EventArgs e)
        {
            MostraFoto(IDCE);
            Console.WriteLine(IDCE);
        }

        public void MostraFoto(String ID)
        {
            string sql = "SELECT Foto FROM tblEstoque2 WHERE ID = '" + ID + "'";
            if (objConect.State != ConnectionState.Open)
                objConect.Open();
            cmd = new SqlCommand(sql, objConect);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                string img = (string)(reader[0]);
                ImgAmpliada.ImageLocation = img;
            }
            objConect.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
