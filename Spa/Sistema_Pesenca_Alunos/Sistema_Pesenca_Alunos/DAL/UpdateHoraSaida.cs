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
    class UpdateHoraSaida
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

        public bool Consultar(String RA,DateTime Inicio, DateTime Fim)
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
           

            if (comand.Equals(""))
            {
                comand = " where RE.Data_Entrada BETWEEN @Inicio AND @Fim";
            }
            else
            {
                comand = comand + " AND RE.Data_Entrada BETWEEN @Inicio AND @Fim";
            }

            cmd.CommandText = @"select RE.Cod_Reserva, RE.Cod_Aluno, DA.Nome_Aluno,RE.Experimento, RE.Data_Entrada from Reserva_Experimentos as RE join Dados_Aluno as DA  on DA.Cod_Aluno = RE.Cod_Aluno " + comand;

            cmd.Parameters.AddWithValue("@Cod_Aluno", RA);            
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

        public bool AtualizarSaida(String Cod_Reserva, String Hora_Saida)
        {
            Check = false;
            cmd.CommandText = @"Update Reserva_Experimentos set HoraSaida = @Hora_Saida where Cod_Reserva = @Cod_Reserva";
            cmd.Parameters.AddWithValue("@Hora_Saida", Hora_Saida);
            cmd.Parameters.AddWithValue("@Cod_Reserva", Cod_Reserva);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                Check = true;
                this.mensagem = "Modificação Concluida";

            }

            catch (SqlException)
            {
                this.mensagem = "Erro ao comunicar com Banco de dados - Reserva Experimentos; \n";
            }

            return Check;
        }
        public bool AtualizarEntrada(String Cod_Reserva, String Hora_Entrada)
        {
            Check = false;
            cmd.CommandText = @"Update Reserva_Experimentos set HoraEntrada = @Hora_Entrada where Cod_Reserva = @Cod_Reserva";
            cmd.Parameters.AddWithValue("@Hora_Entrada", Hora_Entrada);
            cmd.Parameters.AddWithValue("@Cod_Reserva", Cod_Reserva);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                Check = true;
                this.mensagem = "Modificação Concluida";

            }

            catch (SqlException)
            {
                this.mensagem = "Erro ao comunicar com Banco de dados - Reserva Experimentos; \n";
            }

            return Check;
        }
    }
}
