using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEstoque
{
    public class Conexão
    {
        SqlConnection con = new SqlConnection();
        public string SConexao = "";

        //Construtor
        public Conexão() 
        {
            //Code to change according to the README... Server path
            //Código para alterar de acordo com o README... Server path
            con.ConnectionString = @"Data Source=DESKTOP-TTESOU8\SQLEXPRESS;Initial Catalog=LabEstoque;Integrated Security=True";     //Caminho do servidor
            SConexao = con.ConnectionString;    
        }


        //Método para conectar do banco de dados
        public SqlConnection conectar()     //Conecta com o Sql Server
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        //Método para desconectar do banco de dados
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

            return;
        }
    }
}
