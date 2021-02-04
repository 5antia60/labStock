using Sistema_Pesenca_Alunos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pesenca_Alunos.DAL
{
    class CadAlunComands
    {
        public bool Check;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();

        Conexao con = new Conexao();

        SqlDataReader dr;


        public bool verify(String RA)
        {
            if (!RA.Equals(""))
            {
                cmd.CommandText = @"select Registro from tblRegistro where Registro like @RA";
                cmd.Parameters.AddWithValue("@RA", RA);

                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {
                        Check = true;
                    }
                    else
                    {
                        this.mensagem = "RA não se encontra no Banco de Dados - ";
                    }

                }

                catch (SqlException)
                {
                    this.mensagem = "Erro ao comunicar com Banco de dados - Aluno; \n";
                }
            }
            else
            {
                this.mensagem = "Atenção - Campo Vazio!\n";
            }

            return Check;
        }

        public bool Cadastrar(String RA, String Nome_Aluno, String Curso, String Telefone_Aluno, String Celular_Aluno, String Email_Aluno)
        {
            bool temAluno = false;
            CadAlunComands ComandAluno = new CadAlunComands();
            temAluno = ComandAluno.verify(RA);
            Check = false;

            if (temAluno == false)
            {
                cmd.CommandText = @"insert into Dados_Aluno Values(@RA,@Nome_Aluno,@Curso,@Telefone_Aluno,@Celular_Aluno,@Email_Aluno)";
                cmd.Parameters.AddWithValue("@RA", RA);
                cmd.Parameters.AddWithValue("@Nome_Aluno", Nome_Aluno);
                cmd.Parameters.AddWithValue("@Curso", Curso);
                cmd.Parameters.AddWithValue("@Telefone_Aluno", Telefone_Aluno);
                cmd.Parameters.AddWithValue("@Celular_Aluno", Celular_Aluno);
                cmd.Parameters.AddWithValue("@Email_Aluno", Email_Aluno);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    this.mensagem = "Aluno Cadastrado; \n";
                    Check = true;
                }


                catch (SqlException)
                {
                    this.mensagem = "Erro ao comunicar com Banco de dados - Aluno; \n";
                    Check = false;
                }
            }

            else
            {
                this.mensagem = "Aluno ja Cadastrada";
                Check = false;
            }

            return Check;

        }
    }
}
