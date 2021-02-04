using Sistema_Pesenca_Alunos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Pesenca_Alunos.DAL
{
    class Reserva_Exp
    {
        public bool Check;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();

        Conexao con = new Conexao();

        SqlDataReader dr;

        String Nome = "";

        public bool Reservar(String RA, String Curso, String Semestre, String Disciplina, String Experimento, String Professor ,String Sala, String DataEntrada, String HoraEntrada)
        {
            Reserva_Exp nome = new Reserva_Exp();
            nome.Pega_Nome(RA);
            String Nome_Aluno = nome.Nome;

            cmd.CommandText = @"insert into Reserva_Experimentos Values(@Cod_Aluno, @Nome_Aluno, @Curso, @Semestre, @Disciplina, @Experimento, @Nome_Prof, @Sala, @DataEntrada, @HoraEntrada)";
                cmd.Parameters.AddWithValue("@Cod_aluno", RA);
                cmd.Parameters.AddWithValue("@Nome_Aluno", Nome_Aluno);
                cmd.Parameters.AddWithValue("@Curso", Curso);
                cmd.Parameters.AddWithValue("@Semestre", Semestre);
                cmd.Parameters.AddWithValue("@Disciplina", Disciplina);
                cmd.Parameters.AddWithValue("@Experimento", Experimento);                
                cmd.Parameters.AddWithValue("@Nome_Prof", Professor);
                cmd.Parameters.AddWithValue("@Sala", Sala);             
                cmd.Parameters.AddWithValue("@DataEntrada", DataEntrada);
                cmd.Parameters.AddWithValue("@HoraEntrada", HoraEntrada);                

            try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    Check = true;
                }


                catch (SqlException)
                {
                    this.mensagem = "Erro ao comunicar com Banco de dados - Reserva Experimentos; \n";
                    Check = false;
                }
            
            return Check;

        }

        public void Pega_Nome(String RA)
        {
            cmd.CommandText = @"select Nome from tblRegistro where Registro = @Registro";
            cmd.Parameters.AddWithValue("@Registro", RA);            

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        Nome = (string)dr[0];                        
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
    }
}
