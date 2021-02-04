using Sistema_Pesenca_Alunos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pesenca_Alunos.DAL
{
    public class RegOcorrencia
    {
        public bool temRA = false;
        public bool temProf = false;
        public bool temTurma = false;
        public bool temAux = false;
        public bool tem_check = false;
        public bool status = false;
        DateTime Hora_Data;

        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        public String mensagem = "";

        public bool Registro(String Cod_Prof,  String Cod_Aux,  String RA,  String Cod_Turma, String Ocorrencia)
        {
            CadPresenca Checar = new CadPresenca();

            if (Checar.checagem(Cod_Prof, Cod_Aux, RA, Cod_Turma) == true)
            {
                cmd.CommandText = @"insert into Dados_Ocorrencia Values(@RA,@Cod_Turma,@Cod_Prof,@Cod_Aux,@Ocorrencia,@Hora_Data)";
                cmd.Parameters.AddWithValue("@Cod_Prof", Cod_Prof);                
                cmd.Parameters.AddWithValue("@Cod_Aux", Cod_Aux);                
                cmd.Parameters.AddWithValue("@RA", RA);                
                cmd.Parameters.AddWithValue("@Cod_Turma", Cod_Turma);

                Hora_Data = DateTime.Now;
                cmd.Parameters.AddWithValue("@Hora_Data", Hora_Data);

                cmd.Parameters.AddWithValue("@Ocorrencia", Ocorrencia);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    status = true;
                }

                catch (SqlException)
                {
                    this.mensagem = "Erro ao comunicar com Banco de dados - Ocorrencias; \n";
                }
            }

            else
            {
                this.mensagem = Checar.mensagem;
            }

            return status;

        }

        public bool checagem(String Cod_Prof, String Cod_Aux, String RA, String Cod_Turma)
        {
            CadAlunComands ComandAluno = new CadAlunComands();
            CadAuxComands ComandAux = new CadAuxComands();
            CadProfComands ComandProf = new CadProfComands();
            CadTurmaComands ComandTurma = new CadTurmaComands();

            temRA = ComandAluno.verify(RA);
            temProf = ComandProf.verify(Cod_Prof);
            temTurma = ComandTurma.verify(Cod_Turma);
            temAux = ComandAux.verify(Cod_Aux);


            if (temAux == true && temProf == true && temRA == true && temTurma == true)
            {
                tem_check = true;
            }

            else
            {
                this.mensagem = ComandAluno.mensagem + ComandProf.mensagem + ComandAux.mensagem + ComandTurma.mensagem;
            }

            return tem_check;

        }
    }
}
