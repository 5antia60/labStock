using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.DAL
{
    public class btnAdicionarLinhaTblLoginUsuarios
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";

        public btnAdicionarLinhaTblLoginUsuarios(String Nome, String Telefone, String RG, String CPF, String Endereço, String Login, String Senha, String Status)
        {
            cmd.CommandText = "insert into tblLoginUsuarios (Nome, RG, CPF, Endereço, Status, Telefone, Login, Senha) values (@Nome, @RG, @CPF, @Endereço, @Status, @Telefone, @Login, @Senha)";

            if (Nome.Equals("") || RG.Equals("") || CPF.Equals("") || Endereço.Equals("") || Status.Equals("") || Telefone.Equals("") || Login.Equals("") || Senha.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                //Parametros
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@RG", RG);
                cmd.Parameters.AddWithValue("@CPF", CPF);
                cmd.Parameters.AddWithValue("@Endereço", Endereço);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@Telefone", Telefone);
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Senha", Senha);
            }

            try
            {
                //Conectar com o banco de dados -- Conexao
                cmd.Connection = conexao.conectar();

                //executar comando
                cmd.ExecuteNonQuery();

                //Desconectar
                conexao.desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco de dados";
            }
        }
    }
}
