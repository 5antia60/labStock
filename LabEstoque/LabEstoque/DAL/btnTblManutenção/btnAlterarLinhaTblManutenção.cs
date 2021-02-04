using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.DAL
{
    public class btnAlterarLinhaTblManutenção
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";

        public btnAlterarLinhaTblManutenção(String Item, String Data, String Patrimônio, String Ocorrência, String Registro, String Observação, String ID)
        {
            cmd.CommandText = "UPDATE tblManutenção SET Item = @Item, Data = @Data, Patrimônio = @Patrimônio, Ocorrência = @Ocorrência, Registro = @Registro, Observação = @Observação WHERE ID = @ID";

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
