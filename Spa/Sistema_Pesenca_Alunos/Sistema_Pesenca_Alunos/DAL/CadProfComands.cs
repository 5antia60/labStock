using Sistema_Pesenca_Alunos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pesenca_Alunos.DAL
{
    class CadProfComands
    {

        public bool Check;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();

        Conexao con = new Conexao();

        SqlDataReader dr;


        public bool verify(String CodProf)
        {
            cmd.CommandText = @"select Registro from tblRegistro where Registro like @CodProf";
            cmd.Parameters.AddWithValue("@CodProf", CodProf);

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
                    this.mensagem = "Professor não se encontra no Banco de Dados - ";
                }

            }

            catch (SqlException)
            {
                this.mensagem = "Erro ao comunicar com Banco de dados - Professor; \n";
            }

            return Check;
        }

        public bool Cadastrar(String Cod_Prof, String Nome_Prof, String Telefone_Prof, String Celular_Prof, String Email_Prof)
        {
            bool temProf = false;
            CadProfComands ComandProf = new CadProfComands();
            temProf = ComandProf.verify(Cod_Prof);

            if (temProf == false)
            {
                cmd.CommandText = @"insert into Dados_Prof Values(@Cod_Prof,@Nome_Prof,@Telefone_Prof,@Celular_Prof,@Email_Prof)";
                cmd.Parameters.AddWithValue("@Cod_Prof", Cod_Prof);
                cmd.Parameters.AddWithValue("@Nome_Prof", Nome_Prof);
                cmd.Parameters.AddWithValue("@Telefone_Prof", Telefone_Prof);
                cmd.Parameters.AddWithValue("@Celular_Prof", Celular_Prof);
                cmd.Parameters.AddWithValue("@Email_Prof", Email_Prof);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    Check = true;
                }


                catch (SqlException)
                {
                    this.mensagem = "Erro ao comunicar com Banco de dados - Professor; \n";
                    Check = false;
                }
            }

            else
            {
                this.mensagem = "Professor ja Cadastrada";
                Check = false;                
            }

            return Check;

        }
    }
}
