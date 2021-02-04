using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.DAL
{
    public class btnAlterarLinhaTblLoginUsuarios
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";

        public btnAlterarLinhaTblLoginUsuarios(String Nome, String Telefone, String RG, String CPF, String Endereço, String Login, String Senha, String Status, String ID)
        {
            cmd.CommandText = "UPDATE tblLoginUsuarios SET Nome = @Nome, RG = @RG, CPF = @CPF, Endereço = @Endereço, Status = @Status, Telefone = @Telefone, Login = @Login, Senha = @Senha WHERE IdCliente = @ID";

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
                cmd.Parameters.AddWithValue("@ID", ID);
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
