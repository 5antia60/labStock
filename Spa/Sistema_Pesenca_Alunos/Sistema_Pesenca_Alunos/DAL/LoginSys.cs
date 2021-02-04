using Sistema_Pesenca_Alunos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pesenca_Alunos.DAL
{
    class LoginSys
    {
        public bool Check;
        public String mensagem = "";
        public String Nivel = "";
        SqlCommand cmd = new SqlCommand();

        Conexao con = new Conexao();

        SqlDataReader dr;


        public bool FazLogin(String Login, String Senha)
        {
            if (!Login.Equals("") && !Senha.Equals(""))
            {
                cmd.CommandText = @"select Contrato_Aux from Dados_Aux where Login = @Login and Senha = @Senha";
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Senha", Senha);

                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {
                        while (dr.Read())
                        {
                            Nivel = (string)dr[0];
                            Check = true;
                        }
                    }
                    else
                    {
                        this.mensagem = "Usuário ou Senha não Encontrados";
                    }

                }

                catch (SqlException)
                {
                    this.mensagem = "Erro ao comunicar com Banco de dados - Usuarios Registrados; \n";
                }
            }
            else
            {
                this.mensagem = "Atenção - Campo Vazio!\n";
            }

            return Check;
        }

        public bool verifyLogin (String Login)
        {
            bool cond = false;
            cmd.CommandText = @"select Login from Dados_Aux where Login = @Login";
            cmd.Parameters.AddWithValue("@Login", Login);
            
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {
                    this.mensagem = "Este Login ja está sendo utilizado";
                    cond = true;
                }
            }

            catch (SqlException)
            {
                this.mensagem = "Erro ao comunicar com Banco de dados - Usuarios Registrados.";
            }
            return cond;
        }
    }
}
