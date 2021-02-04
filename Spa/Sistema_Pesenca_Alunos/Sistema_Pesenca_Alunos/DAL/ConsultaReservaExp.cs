using Sistema_Pesenca_Alunos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Pesenca_Alunos.DAL
{
    class ConsultaReservaExp
    {
        public bool Check;
        public String mensagem = "";
        public String comand = "";

        public SqlDataAdapter sda = new SqlDataAdapter();

        SqlCommand cmd = new SqlCommand();

        Conexao con = new Conexao();

        SqlDataReader dr;
        DataTable dt = new DataTable();
        public BindingSource bind = new BindingSource();

        public bool Consultar(String RA, String Curso, String Semestre, String Disciplina, String Experimento, DateTime Inicio, DateTime Fim)
        {
            bool concluido = false;


            if (!RA.Equals(""))
            {
                if (comand.Equals(""))
                {
                    comand = " Where RE.Cod_aluno = @Cod_Aluno";
                }
                else
                {
                    comand = comand + " AND RE.Cod_aluno = @Cod_aluno";
                }
            }
            if (!Curso.Equals("Selecionar"))
            {
                if (comand.Equals(""))
                {
                    comand = " Where RE.Curso = @Curso";
                }
                else
                {
                    comand = comand + " AND RE.Curso = @Curso";
                }

            }
            if (!Semestre.Equals("Selecionar") && !Semestre.Equals("Selecionar Curso"))
            {
                if (comand.Equals(""))
                {
                    comand = " Where RE.Semestre = @Semestre";
                }
                else
                {
                    comand = comand + " AND RE.Semestre = @Semestre";
                }

            }
            if (!Disciplina.Equals("Selecionar") && !Disciplina.Equals("Selecionar Semestre") && !Disciplina.Equals("Sem elementos correspondentes"))
            {
                if (comand.Equals(""))
                {
                    comand = " Where RE.Disciplina = @Disciplina";
                }
                else
                {
                    comand = comand + " AND RE.Disciplina = @Disciplina";
                }

            }
            if (!Experimento.Equals("Selecionar") && !Experimento.Equals("Selecionar Disciplina") && !Experimento.Equals("Sem elementos correspondentes"))
            {
                if (comand.Equals(""))
                {
                    comand = " Where RE.Experimento = @Experimento";
                }
                else
                {
                    comand = comand + " AND RE.Experimento = @Experimento";
                }
            }

            if (comand.Equals(""))
            {
                comand = " where RE.Data_Entrada BETWEEN @Inicio AND @Fim";
            }
            else
            {
                comand = comand + " AND RE.Data_Entrada BETWEEN @Inicio AND @Fim";
            }

            cmd.CommandText = @"select RE.Cod_Reserva, RE.Cod_Aluno, DA.Nome_Aluno, DA.Telefone_Aluno, DA.Celular_Aluno, DA.Email_Aluno,RE.Curso, RE.Semestre, RE.Disciplina,RE.Experimento, RE.Data_Entrada from Reserva_Experimentos as RE join Dados_Aluno as DA  on DA.Cod_Aluno = RE.Cod_Aluno " + comand;

            cmd.Parameters.AddWithValue("@Cod_Aluno", RA);
            cmd.Parameters.AddWithValue("@Curso", Curso);
            cmd.Parameters.AddWithValue("@Semestre", Semestre);
            cmd.Parameters.AddWithValue("@Disciplina", Disciplina);
            cmd.Parameters.AddWithValue("@Experimento", Experimento);
            cmd.Parameters.AddWithValue("@Inicio", Inicio);
            cmd.Parameters.AddWithValue("@Fim", Fim);

            this.comand = cmd.CommandText;

            //faz comunicação
            try
            {
                cmd.Connection = con.conectar();

                sda.SelectCommand = cmd;
                sda.Fill(dt);
                bind.DataSource = dt;


                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    this.mensagem = "Encontrado";
                    Check = true;
                }
                else
                {
                    this.mensagem = "Não há informações com estes critérios no Banco de Dados";
                    Check = true;
                }

            }

            catch (SqlException)
            {
                this.mensagem = "Erro ao comunicar com Banco de dados - Consulta - Presencas; \n";
            }
                        
            return concluido;
        }
    }
}
