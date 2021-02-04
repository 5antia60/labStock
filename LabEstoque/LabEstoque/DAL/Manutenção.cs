using LabEstoque.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEstoque
{
    public class Manutenção
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";
        public string qnt = "";

        public Manutenção(String Item, String Patrimônio, String Ocorrência, String Registro, String Data, String Observação, String ID)
        {
            if (Ocorrência == "Item quebrado")
            {
                //Comando Sql -- insert, update, delete --> SqlCommand
                cmd.CommandText = "insert into tblManutenção (Item, Patrimônio, Ocorrência, Registro, Data, Observação) values (@Item, @Patrimônio, @Ocorrência, @Registro, @Data, @Observação)";
            }
            else
            {
                cmd.CommandText = "UPDATE tblManutenção SET Ocorrência = 'Item consertado' WHERE ID = '" + ID + "'";
            }

            if (Item.Equals("") || Ocorrência.Equals("") || Data.Equals("") || Registro.Equals(""))
            {
                qnt = "Preencha todos os campos";
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

                if (Ocorrência == "Item quebrado")
                {
                    SaidaItens SI = new SaidaItens("1", Item, Patrimônio, "Quebrado");
                }
                else
                {
                    VoltaItens VI = new VoltaItens("1", Item, Patrimônio, ID);
                }
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
                this.mensagem = "Ocorrência registrada com sucesso...";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados...  " + qnt + " ";
            }

        }
    }
}
