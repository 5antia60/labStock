using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEstoque.DAL
{
    public class SaidaItens
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";

        public SaidaItens(String QntAtual, String Item, String Patrimônio, String Caso)
        {
            if (Patrimônio == "")
            {
                cmd.CommandText = @"UPDATE tblEstoque2 SET Quantidade_Atual = Quantidade_Atual - '"+ QntAtual +"' WHERE Item LIKE '"+ Item +"'";
            }
            else
            {
                cmd.CommandText = @"UPDATE tblEstoque2 SET Quantidade_Atual = Quantidade_Atual - 1 WHERE Item like @Item UPDATE tblPatrimônio2 SET Situação = '"+ Caso +"' WHERE Patrimônio like @Patrimonio and Patrimônio not like 'X'";
                cmd.Parameters.AddWithValue("@Item", Item);
                cmd.Parameters.AddWithValue("@Patrimonio", Patrimônio);
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
                this.mensagem = "Erro ao se conectar com o estoque e patrimônios";
            }
        }
    }
}
