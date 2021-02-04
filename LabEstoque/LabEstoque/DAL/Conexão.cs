using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://youtu.be/HihxWOXxFic Video de conexão do projeto

namespace LabEstoque
{
    public class Conexão
    {
        SqlConnection con = new SqlConnection();
        public string SConexao = "";

        //Construtor
        public Conexão() 
        {
            con.ConnectionString = @"Data Source=C-153\SQLEXPRESS01;Initial Catalog=BDLabD28;Integrated Security=True";     //Caminho do servidor
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
