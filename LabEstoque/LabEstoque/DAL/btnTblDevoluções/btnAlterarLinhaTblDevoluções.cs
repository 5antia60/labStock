using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.DAL
{
    public class btnAlterarLinhaTblDevoluções
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";

        public btnAlterarLinhaTblDevoluções(String Item, String Quantidade, String Data, String Observação, String Patrimônio, String Registro, String Responsavel, String ID)
        {
            cmd.CommandText = "UPDATE tblDevoluções SET Item = @Item, Quantidade = @Quantidade, Data = @Data, Observação = @Observação, Patrimônio = @Patrimônio, Registro = @Registro, Responsavel = @Responsavel WHERE ID = @ID";

            if (Item.Equals("") || Quantidade.Equals("") || Data.Equals("") || Patrimônio.Equals("") || Registro.Equals("") || Responsavel.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                //Parametros
                cmd.Parameters.AddWithValue("@Item", Item);
                cmd.Parameters.AddWithValue("@Quantidade", Quantidade);
                cmd.Parameters.AddWithValue("@Data", Data);
                cmd.Parameters.AddWithValue("@Observação", Observação);
                cmd.Parameters.AddWithValue("@Patrimônio", Patrimônio);
                cmd.Parameters.AddWithValue("@Registro", Registro);
                cmd.Parameters.AddWithValue("@Responsavel", Responsavel);
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
