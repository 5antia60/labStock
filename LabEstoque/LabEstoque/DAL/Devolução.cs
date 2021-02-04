using LabEstoque.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque
{
    public class Devolução
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";
        public string qnt = "";

        public Devolução(String Item, String Quantidade, String Data, String Observação, String Patrimônio, String Registro, String Responsavel, String ID, String ID1)
        {
            //Comando Sql -- insert, update, delete --> SqlCommand
            cmd.CommandText = "insert into tblDevoluções (Item, Quantidade, Data, Observação, Patrimônio, Registro, Responsavel) values (@Item, @Quantidade, @Data, @Observação, @Patrimônio, @Registro, @Responsavel)";

            if (Item.Equals("") || Quantidade.Equals("") || Data.Equals("") || Responsavel.Equals("") || Registro.Equals(""))
            {
                qnt = "Preencha todos os campos";
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

                VoltaItens VI = new VoltaItens(Quantidade, Item, Patrimônio, ID1);
            }

            try
            {
                //Conectar com o banco de dados -- Conexao
                cmd.Connection = conexao.conectar();

                //executar comando
                cmd.ExecuteNonQuery();

                //Desconectar
                conexao.desconectar();

                //Mostrar mensagem de erro ou sucesso == variavel
                this.mensagem = "Item devolvido com Sucesso...";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados...  " + qnt + " ";
            }
        }
    }
}
