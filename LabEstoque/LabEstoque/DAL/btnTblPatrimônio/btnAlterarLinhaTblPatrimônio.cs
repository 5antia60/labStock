using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.DAL
{
    public class btnAlterarLinhaTblPatrimônio
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";

        public btnAlterarLinhaTblPatrimônio(String Item, String Código, String Patrimônio, String Situação, String ID)
        {
            cmd.CommandText = "UPDATE tblPatrimônio2 SET Item = @Item, Patrimônio = @Patrimônio, Código = @Código, Situação = @Situação WHERE ID = @ID";

            if (Item.Equals("") || Patrimônio.Equals("") || Situação.Equals("") || ID.Equals("") || Código.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                //Parametros
                cmd.Parameters.AddWithValue("@Item", Item);
                cmd.Parameters.AddWithValue("@Código", Código);
                cmd.Parameters.AddWithValue("@Patrimônio", Patrimônio);
                cmd.Parameters.AddWithValue("@Situação", Situação);
                cmd.Parameters.AddWithValue("@ID", ID);
            }

            try
            {
                //Conectar com o banco de dados -- Conexao
                cmd.Connection = conexao.conectar();

                //executar comando
                cmd.ExecuteNonQuery();

                //Desconectar
                conexao.desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados";
            }
        }

    }
}
