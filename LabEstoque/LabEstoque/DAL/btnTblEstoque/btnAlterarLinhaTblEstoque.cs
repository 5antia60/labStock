using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.DAL
{
    public class btnAlterarLinhaTblEstoque
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";

        public btnAlterarLinhaTblEstoque(String Item, String QuantidadeTotal, String QuantidadeAtual, String Descrição, String Sala, String Armário, String Espécie, String Classificação, String ID)
        {
            cmd.CommandText = "UPDATE tblEstoque2 SET Item = @Item, Quantidade_Total = @QuantidadeTotal, Quantidade_Atual = @QuantidadeAtual, Descrição = @Descrição, Sala = @Sala, Armário = @Armário, Espécie = @Espécie, Classificação = @Classificação WHERE ID = @ID";

            if (Item.Equals("") || QuantidadeTotal.Equals("") || QuantidadeAtual.Equals("") || Sala.Equals("") || Descrição.Equals("") || Armário.Equals("") || Espécie.Equals("") || Classificação.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                //Parametros
                cmd.Parameters.AddWithValue("@Item", Item);
                cmd.Parameters.AddWithValue("@QuantidadeTotal", QuantidadeTotal);
                cmd.Parameters.AddWithValue("@QuantidadeAtual", QuantidadeAtual);
                cmd.Parameters.AddWithValue("@Sala", Sala);
                cmd.Parameters.AddWithValue("@Descrição", Descrição);
                cmd.Parameters.AddWithValue("@Armário", Armário);
                cmd.Parameters.AddWithValue("@Espécie", Espécie);
                cmd.Parameters.AddWithValue("@Classificação", Classificação);
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
