using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.DAL
{
    public class btnAdicionarLinhaTblManutenção
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";

        public btnAdicionarLinhaTblManutenção(String Item, String Data, String Patrimônio, String Ocorrência, String Registro, String Observação)
        {
            cmd.CommandText = "insert into tblManutenção (Item, Data, Patrimônio, Ocorrência, Registro, Observação) values (@Item, @Data, @Patrimônio, @Ocorrência, @Registro, @Observação)";

            if (Item.Equals("") || Data.Equals("") || Patrimônio.Equals("") || Ocorrência.Equals("") || Registro.Equals("") || Observação.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                //Parametros
                cmd.Parameters.AddWithValue("@Item", Item);
                cmd.Parameters.AddWithValue("@Data", Data);
                cmd.Parameters.AddWithValue("@Patrimônio", Patrimônio);
                cmd.Parameters.AddWithValue("@Ocorrência", Ocorrência);
                cmd.Parameters.AddWithValue("@Registro", Registro);
                cmd.Parameters.AddWithValue("@Observação", Observação);
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
