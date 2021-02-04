using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEstoque.DAL
{
    public class VoltaItens
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";

        public VoltaItens(String QuantidadeDevolvida, String Item, String Patrimônio, String ID)
        {
            if (Patrimônio == "")//Se o item não tiver patrimônio...
            {
                cmd.CommandText = "UPDATE tblEstoque2 SET Quantidade_Atual = Quantidade_Atual + @QuantidadeDevolvida WHERE Item like @Item UPDATE tblEmpréstimos SET Itens_para_devolver = Itens_para_devolver - @QuantidadeDevolvida WHERE ID like @ID";
                cmd.Parameters.AddWithValue("@ID", ID);
            }
            else //Se o item tiver patrimônio...
            {
                cmd.CommandText = "UPDATE tblEmpréstimos SET Itens_para_devolver = '0' WHERE Patrimônio like @Patrimônio UPDATE tblPatrimônio2 SET Situação = 'Disponível' WHERE Patrimônio like @Patrimônio UPDATE tblEstoque2 SET Quantidade_Atual = Quantidade_Atual + @QuantidadeDevolvida WHERE Item like @Item";
                cmd.Parameters.AddWithValue("@Patrimônio", Patrimônio);
            }

            cmd.Parameters.AddWithValue("@Item", Item);
            cmd.Parameters.AddWithValue("@QuantidadeDevolvida", QuantidadeDevolvida);

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
                this.mensagem = "Erro ao se conectar com o estoque";
            }
        }
    }
}

