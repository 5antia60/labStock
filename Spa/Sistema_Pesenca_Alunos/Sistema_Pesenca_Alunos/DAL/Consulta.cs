using Sistema_Pesenca_Alunos.Modelo;
using Sistema_Pesenca_Alunos.Telas;
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
    public class Consulta
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
        
        public bool Consultar(String Cod_Prof, String Cod_Aux, String RA, String Cod_Turma, DateTime Inicio, DateTime Fim)
        {
            bool concluido = false;
            Check = false;


            if(!Cod_Prof.Equals(""))
            {
                if (comand.Equals(""))
                {
                    comand = " Where DPR.Cod_Prof = @Cod_prof";
                }
                else 
                {
                    comand = comand + " AND DPR.Cod_Prof = @Cod_prof";
                }
            }
            if (!Cod_Aux.Equals(""))
            {
                if (comand.Equals(""))
                {
                    comand = " Where DPR.Cod_Aux = @Cod_Aux";
                }
                else
                {
                    comand = comand + " AND DPR.Cod_Aux = @Cod_Aux";
                }

            }
            if (!RA.Equals(""))
            {
                if (comand.Equals(""))
                {
                    comand = " Where DPR.Cod_Aluno = @Cod_Aluno";
                }
                else
                {
                    comand = comand + " AND DPR.Cod_aluno = @Cod_Aluno";
                }

            }
            if (!Cod_Turma.Equals(""))
            {
                if (comand.Equals(""))
                {
                    comand = " Where DPR.Cod_Turma = @Cod_Turma";
                }
                else
                {
                    comand = comand + " AND DPR.Cod_Turma = @Cod_Turma";
                }               
            }

            if (comand.Equals(""))
            {
                comand = " where DPR.Hora_Dia BETWEEN @Inicio AND @Fim";
            }
            else
            {
                comand = comand + " AND DPR.Hora_Dia BETWEEN @Inicio AND @Fim";
            }

            cmd.CommandText = @"Select DPR.Hora_Dia, DA.Cod_Aluno, DA.Nome_Aluno, DPR.Temp_Aluno, DT.Cod_Turma, DT.Nome_Turma, DP.COD_prof, DP.Nome_Prof, DPR.Temp_prof, DAU.Cod_Aux, DAU.Nome_Aux, DPR.Temp_Aux, DPR.Observacao from Dados_Presenca as DPR join Dados_Aluno as DA  on DA.Cod_Aluno = DPR.Cod_Aluno join Dados_turma as DT  on DT.Cod_Turma = DPR.Cod_turma  join Dados_Prof as DP  on DP.Cod_Prof = DPR.Cod_prof join Dados_Aux as DAU on DAU.Cod_Aux = DPR.Cod_Aux" + comand;

            cmd.Parameters.AddWithValue("@Cod_Prof", Cod_Prof);
            cmd.Parameters.AddWithValue("@Cod_Aux", Cod_Aux);
            cmd.Parameters.AddWithValue("@Cod_Aluno", RA);
            cmd.Parameters.AddWithValue("@Cod_Turma", Cod_Turma);
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
