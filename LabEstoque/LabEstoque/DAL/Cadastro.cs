using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque
{
    public class Cadastro
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";

        public Cadastro(String Nome, String RG, String CPF, String Endereço, String Status, String Telefone, String Registro, String Telefone_2, String Email)
        {
            //Comando Sql -- insert, update, delete --> SqlCommand
            cmd.CommandText = "insert into tblRegistro (Nome, RG, CPF, Endereço, Status, Telefone, Registro, Telefone_2, Email) values (@Nome, @RG, @CPF, @Endereço, @Status, @Telefone, @Registro, @Telefone_2, @Email)";

            if (Nome.Equals("") || RG.Equals("") || CPF.Equals("") || Endereço.Equals("") || Status.Equals("") || Telefone.Equals("") || Registro.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                //Parametros
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@RG", RG);
                cmd.Parameters.AddWithValue("@CPF", CPF);
                cmd.Parameters.AddWithValue("@Endereço", Endereço);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@Telefone", Telefone);
                cmd.Parameters.AddWithValue("@Registro", Registro);
                cmd.Parameters.AddWithValue("@Telefone_2", Telefone_2);
                cmd.Parameters.AddWithValue("@Email", Email);
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
                this.mensagem = "Cadastrado com Sucesso...";
            } 
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados...";
            }

            //Executar o comando

        }
    }
}
