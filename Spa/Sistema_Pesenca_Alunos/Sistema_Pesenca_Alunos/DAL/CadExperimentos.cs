using Sistema_Pesenca_Alunos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pesenca_Alunos.DAL
{
    class CadExperimentos
    {
        public bool Check;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();

        Conexao con = new Conexao();               

        public bool Cad_Todos_Exp (String Disciplina, String Experimento, String Material)
        {
            cmd.CommandText = @"insert into Dados_Experimentos Values(@Experimento, @Disciplina, @Material)";

            cmd.Parameters.AddWithValue("@Disciplina", Disciplina);
            cmd.Parameters.AddWithValue("@Experimento", Experimento);
            cmd.Parameters.AddWithValue("@Material", Material);     

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                this.mensagem = "Experimento Registrado";
                Check = true;
            }


            catch (SqlException)
            {
                this.mensagem = "Erro ao comunicar com Banco de dados - Dados Experimentos";
                Check = false;
            }

            return Check;
        }
    }
}
