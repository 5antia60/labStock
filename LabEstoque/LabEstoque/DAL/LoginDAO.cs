using LabEstoque.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque
{
    class TelaConsultaInicial
    {
        public bool tem = false;
        public string nivel;
        public string Nome;
        public String mensagem = ""; //Tudo ok (se estiver vazia)
        SqlCommand cmd = new SqlCommand();
        Conexão con = new Conexão();
        SqlDataReader dr;
        string senha;
        Criptografia BD = new Criptografia();

        public bool verificarLogin(String Login, String Senha)
        {
            senha = BD.Criptografar(Senha);

            //procurar no banco esse login e senha
            cmd.CommandText = "select Status from tblLoginUsuarios where Login = @Login and Senha = @Senha";
            cmd.Parameters.AddWithValue("@Login", Login);
            cmd.Parameters.AddWithValue("@Senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) //Se foi encontrado
                {
                    while (dr.Read())
                    {
                        nivel = (string)dr[0];
                        tem = true;
                    }
                }
                con.desconectar();
                dr.Close();

            }
            catch
            {
                this.mensagem = "Erro com banco de dados...";
            }
            return tem;
        }

        public string nome (String Login)
        {
            cmd.CommandText = "SELECT  SUBSTRING(Nome, 1, CHARINDEX(' ', Nome)) FROM tblLoginUsuarios WHERE Login = @Login";

            cmd.Parameters.AddWithValue("@Login", Login);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) //Se foi encontrado
                {
                    while (dr.Read())
                    {
                        Nome = (string)dr[0];
                    }
                }
                con.desconectar();
                dr.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Erro ao exibir o nome");
            }
            return Nome;
        }

        public String cadastrar(String Nome, String Telefone, String RG, String CPF, String Endereço, String Login, String Senha, String confSenha, String Status)
        {
            tem = false;

            //comandos para inserir
            if (Senha.Equals(confSenha))
            {
                senha = BD.Criptografar(Senha);
                Console.WriteLine(senha);

                cmd.CommandText = "insert into tblLoginUsuarios (Nome, Telefone, RG, CPF, Endereço, Login, Senha, Status) values (@Nome, @Telefone, @RG, @CPF, @Endereço, @Login, @Senha, @Status)";

                if (Nome.Equals("") || Telefone.Equals("") || RG.Equals("") || CPF.Equals("") || Endereço.Equals("") || Login.Equals("") || Senha.Equals("") || confSenha.Equals("") || Status.Equals(""))
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@Telefone", Telefone);
                    cmd.Parameters.AddWithValue("@RG", RG);
                    cmd.Parameters.AddWithValue("@CPF", CPF);
                    cmd.Parameters.AddWithValue("@Endereço", Endereço);
                    cmd.Parameters.AddWithValue("@Login", Login);
                    cmd.Parameters.AddWithValue("@Senha", senha);
                    cmd.Parameters.AddWithValue("@Status", Status);
                }

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso...";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Banco de Dados";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem...";
            }
            return mensagem;
        }
    }
}
