using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.DAL
{
    public class btnAdicionarLinhaTblEstoque
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";

        public btnAdicionarLinhaTblEstoque(String Item, String QuantidadeTotal, String QuantidadeAtual, String Descrição, String Sala, String Armário, String Espécie, String Classificação)
        {
            cmd.CommandText = "insert into tblEstoque2 (Item, Quantidade_Total, Quantidade_Atual, Descrição, Sala, Armário, Espécie, Classificação) values (@Item, @QuantidadeTotal, @QuantidadeAtual, @Descrição, @Sala, @Armário, @Espécie, @Classificação)";

            if (Item.Equals("") || QuantidadeTotal.Equals("") || QuantidadeAtual.Equals("") || Descrição.Equals("") || Sala.Equals("") || Armário.Equals("") || Espécie.Equals("") || Classificação.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                //Parametros
                cmd.Parameters.AddWithValue("@Item", Item);
                cmd.Parameters.AddWithValue("@QuantidadeTotal", QuantidadeTotal);
                cmd.Parameters.AddWithValue("@QuantidadeAtual", QuantidadeAtual);
                cmd.Parameters.AddWithValue("@Descrição", Descrição);
                cmd.Parameters.AddWithValue("@Sala", Sala);
                cmd.Parameters.AddWithValue("@Armário", Armário);
                cmd.Parameters.AddWithValue("@Espécie", Espécie);
                cmd.Parameters.AddWithValue("@Classificação", Classificação);
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
