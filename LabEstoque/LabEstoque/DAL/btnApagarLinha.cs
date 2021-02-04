using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.DAL
{
    public class btnApagarLinha
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";

        public btnApagarLinha(String Tabela, String ID, String ColID)
        {
            cmd.CommandText = "delete from " + Tabela + " where "+ ColID +" = @ID";

            //Parametros
            cmd.Parameters.AddWithValue("@ID", ID);

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
