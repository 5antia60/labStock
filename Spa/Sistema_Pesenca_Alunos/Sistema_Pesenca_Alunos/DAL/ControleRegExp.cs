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
    

    public class ControleRegExp
    {
        public String[] Cursos;
        public String[] SemestresFix;
        public String[] Semestres;
        public List<String> Disciplinas = new List<String>();
        public List<String> Experimentos = new List<String>();
        public List<String> Horas = new List<String>();

        public String mensagem = "";
        public bool Check = false;
                
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public int i = 0;
        public int quant = 0;

        public void Todos_Cursos()
        {
            Cursos = new String[] { "Selecionar", "Tecnologia em Análise e Desenvolvimento de Sistemas", "Tecnologia em Gestão de T.I.", "Tecnologia em Banco de Dados", "Engenharia Química", "Engenharia de Produção", "Engenharia Civil", "Engenharia de Computação", "Engenharia Elétrica", "Engenharia Mecânica", "Engenharia Mecatrônica", "Tecnologia em Jogos Digitais", "Engenharia de Alimentos", "Engenharia Agronômica", "Arquitetura e Urbanismo" };
        }

        public void Todos_SemestresFix()
        {
            SemestresFix = new String[] { "Selecionar", "1° Semestre", "2° Semestre", "3° Semestre", "4° Semestre", "5° Semestre", "6° Semestre", "7° Semestre", "8° Semestre", "9° Semestre", "10° Semestre"};
        }

        public void Todas_Disciplina(String Experimento, String Semestre)
        {
            if (Semestre.Equals("Selecionar"))
            {
                Disciplinas.Add ("Selecionar Semestre");
                Check = true;

            }
            else 
            {
                cmd.CommandText = @"Select Disciplina from Dados_Experimentos";
                cmd.Parameters.AddWithValue("@Experimento", Experimento);

                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        Disciplinas.Add("Selecionar");

                        while (dr.Read())
                        {
                            i = 0;
                            quant = 0;
                            while (i < Disciplinas.Count)
                            {
                                if (dr.GetString(0) == Disciplinas[i])
                                {
                                    quant++;
                                }                               
                                i++;
                            }
                            if (quant == 0)
                            {
                                Disciplinas.Add(dr.GetString(0));
                            }
                        }
                        Check = true;
                    }
                    else
                    {
                        Disciplinas.Add("Sem elementos correspondentes");
                        Check = true;
                    }
                    
                }

                catch(SqlException)
                {
                    this.mensagem = "Erro ao comunicar com Banco de dados - Dados_Experimentos";
                    Check = false;
                }
            }
        }

        public void Todos_Experimentos (String Curso, String Semestre, String Disciplina)
        {
            if (Disciplina.Equals("Selecionar") || Disciplina.Equals("Selecionar Semestre"))
            {
                Experimentos.Add("Selecionar Disciplina");
                Check = true;
            }
            else
            {
                cmd.CommandText = @"Select Experimento from Dados_Experimentos where Disciplina = @Disciplina";

                cmd.Parameters.AddWithValue("@Disciplina", Disciplina);
                
                try
                {                   
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {                        
                        Experimentos.Add("Selecionar");
                        while (dr.Read())
                        {
                            i = 0;
                            quant = 0;
                            while (i < Experimentos.Count)
                            {
                                if (dr.GetString(0) == Experimentos[i])
                                {
                                    quant++;
                                }
                                i++;
                            }
                            if (quant == 0)
                            {
                                Experimentos.Add(dr.GetString(0));
                            }
                        }
                        Check = true;
                    }
                    else
                    {                        
                        Experimentos.Add("Sem elementos correspondentes");
                        Check = true;
                    }

                }

                catch (SqlException)
                {                    
                    this.mensagem = "Erro ao comunicar com Banco de dados - Dados_Experimentos";
                    Check = false;
                }
            }
        }
    }
}
