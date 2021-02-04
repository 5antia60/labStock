using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEstoque.DAL
{
    public class btnAdicionarLinhaTblEmpréstimos
    {
        SqlCommand cmd = new SqlCommand();
        Conexão conexao = new Conexão();
        public String mensagem = "";

        public btnAdicionarLinhaTblEmpréstimos(String Item, String Quantidade, String Data, String Patrimônio, String PrevisãoDeDevolução, String Registro, String Setor_Materia, String Responsavel, String Itens_para_devolver)
        {
            cmd.CommandText = "insert into tblEmpréstimos (Item, Quantidade, Data, Patrimônio, PrevisãoDeDevolução, Registro, Setor_Materia, Responsavel, Itens_para_devolver) values (@Item, @Quantidade, @Data, @Patrimônio, @PrevisãoDeDevolução, @Registro, @Setor_Materia, @Responsavel, @Itens_para_devolver)";

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
                cmd.Parameters.AddWithValue("Setor_Materia", Setor_Materia);
                cmd.Parameters.AddWithValue("@Responsavel", Responsavel);
                cmd.Parameters.AddWithValue("@Itens_para_devolver", Itens_para_devolver);
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
