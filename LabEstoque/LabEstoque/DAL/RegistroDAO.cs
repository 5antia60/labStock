using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEstoque.DAL
{
    class RegistroDAO
    {
        public bool tem = false;
        public String mensagem = ""; //Tudo ok (se estiver vazia)
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        SqlDataReader dr;

        public bool verificarRegistro(String Registro)
        {
            //procurar no banco esse registro
            cmd.CommandText = "select * from tblRegistro where Registro = @Registro";
            cmd.Parameters.AddWithValue("@Registro", Registro);

            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) //Se foi encontrado
                {
                    tem = true;
                }
                conexao.desconectar();
                dr.Close();

            }
            catch
            {
                this.mensagem = "Erro com banco de dados...";
            }
            return tem;
        }
    }
}
