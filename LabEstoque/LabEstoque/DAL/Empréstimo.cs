using LabEstoque.DAL;
using LabEstoque.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque
{
    public class Empréstimo
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";
        public string qnt = "";

        public Empréstimo(String Item, String Quantidade, String Data, String Patrimônio, String PrevisãoDeDevolução, String Registro, String Responsavel, String Setor_Materia)
        {
            //Comando Sql -- insert, update, delete --> SqlCommand
            cmd.CommandText = "insert into tblEmpréstimos (Item, Quantidade, Data, Patrimônio, PrevisãoDeDevolução, Registro, Setor_Materia, Responsavel, Itens_para_devolver) values (@Item, @Quantidade, @Data, @Patrimônio, @PrevisãoDeDevolução, @Registro, @Setor_Materia, @Responsavel, @Quantidade)";
            
            if (Item.Equals("") || Quantidade.Equals("") || Data.Equals("") || PrevisãoDeDevolução.Equals("") || Registro.Equals("") || Responsavel.Equals(""))
            {
                qnt = "Preencha todos os campos";
            }
            else
            {
                //Parametros
                cmd.Parameters.AddWithValue("@Item", Item);
                cmd.Parameters.AddWithValue("@Quantidade", Quantidade);
                cmd.Parameters.AddWithValue("@Data", Data);
                cmd.Parameters.AddWithValue("@Patrimônio", Patrimônio);
                cmd.Parameters.AddWithValue("@PrevisãoDeDevolução", PrevisãoDeDevolução);
                cmd.Parameters.AddWithValue("@Registro", Registro);
                cmd.Parameters.AddWithValue("@Setor_Materia", Setor_Materia);
                cmd.Parameters.AddWithValue("@Responsavel", Responsavel);

                SaidaItens SI = new SaidaItens(Quantidade, Item, Patrimônio, "Emprestado");
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
                this.mensagem = "Item emprestado com Sucesso...";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados...  "+ qnt +" ";
            }
            
        } 
    }
}
