using Sistema_Pesenca_Alunos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pesenca_Alunos.DAL
{
    class CadTurmaComands
    {
        public bool Check;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();

        Conexao con = new Conexao();

        SqlDataReader dr;

        public bool temTurma = false;


        public bool verify(String CodTurma)
        {
            cmd.CommandText = @"select Cod_Turma from Dados_Turma where Cod_Turma = @CodTurma";
            cmd.Parameters.AddWithValue("@CodTurma", CodTurma);

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
                    this.mensagem = "Esta turma não se encontra no Banco de Dados - ";
                    Check = false;
                }

            }

            catch (SqlException)
            {
                this.mensagem = "Erro ao comunicar com Banco de dados - Turma; \n";
            }

            return Check;
        }

        public bool Cadastrar (String Nome_Materia, String Cod_Turma, String Período)
        {
            CadTurmaComands ComandTurma = new CadTurmaComands();
            temTurma = ComandTurma.verify(Cod_Turma);

            if (temTurma == false)
            {
                cmd.CommandText = @"insert into Dados_Turma Values(@Cod_Turma, @Materia, @Periodo)";
                cmd.Parameters.AddWithValue("@Cod_Turma", Cod_Turma);
                cmd.Parameters.AddWithValue("@Materia", Nome_Materia);
                cmd.Parameters.AddWithValue("@Periodo", Período);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    Check = true;
                }

                catch (SqlException)
                {
                    this.mensagem = "Erro ao comunicar com Banco de dados - Turma; \n";
                    Check = false;
                }
            }
            else
            {
                this.mensagem = "Turma ja Cadastrada";
                Check = false;
            }
            return Check;
        }
    }
}
