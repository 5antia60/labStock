using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pesenca_Alunos.Modelo
{
    public class Conexao //Cria classe Conexao
    {
        SqlConnection con = new SqlConnection();
        public string SConexao = "";

        public Conexao() //define o endereço do Banco de Dados
        {
            con.ConnectionString = @"Data Source=C-153\SQLEXPRESS01;Initial Catalog=BDLabD28;Integrated Security=True";
            SConexao = con.ConnectionString;
        }

        public SqlConnection conectar()//Função que abre conexao com o Banco de Dados
        {
            if(con.State == System.Data.ConnectionState.Closed)//Se a conexao estiver fechada
            {
                con.Open(); //abre a conexão
            }
            return con;
        }

        public void desconectar ()//Função que fecha a conexão com o Banco de Dados 
        {
            if (con.State == System.Data.ConnectionState.Open) //Se a conexão está aberta
            {
                con.Close(); //Fecha conexão
            }
        }

    }
}
