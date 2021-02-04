using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.DAL
{
    public class btnAlterarLinhaTblEmpréstimos
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";

        public btnAlterarLinhaTblEmpréstimos(String Item, String Quantidade, String Data, String Patrimônio, String PrevisãoDeDevolução, String Registro, String Setor_Materia, String Responsavel, String Itens_para_devolver, String ID)
        {
            cmd.CommandText = "UPDATE tblEmpréstimos SET Item = @Item, Quantidade = @Quantidade, Data = @Data, Patrimônio = @Patrimônio, PrevisãoDeDevolução = @PrevisãoDeDevolução, Registro = @Registro, Setor_Materia = @Setor_Materia, Responsavel = @Responsavel, Itens_para_devolver = @Itens_para_devolver WHERE ID = @ID";

            if (Item.Equals("") || Quantidade.Equals("") || Data.Equals("") || PrevisãoDeDevolução.Equals("") || Registro.Equals("") || Setor_Materia.Equals("") || Responsavel.Equals("") || Itens_para_devolver.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                //Parametros
                cmd.Parameters.AddWithValue("@Item", Item);
                cmd.Parameters.AddWithValue("@Quantidade", Quantidade);
                cmd.Parameters.AddWithValue("@Data", Data);
                cmd.Parameters.AddWithValue("@Patrimônio", Patrimônio);
                cmd.Parameters.AddWithValue("@PrevisãoDeDevolução", PrevisãoDeDevolução);
                cmd.Parameters.AddWithValue("@Registro", Registro);
                cmd.Parameters.AddWithValue("@Setor_Materia", Setor_Materia);
                cmd.Parameters.AddWithValue("@Responsavel", Responsavel);
                cmd.Parameters.AddWithValue("@Itens_para_devolver", Itens_para_devolver);
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
