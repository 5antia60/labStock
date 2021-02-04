using Sistema_Pesenca_Alunos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Pesenca_Alunos.DAL
{
    class CadAuxComands
    {
        public bool Check;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();

        Conexao con = new Conexao();

        SqlDataReader dr;


        public bool verify(String CodAux)
        {
            cmd.CommandText = @"select Registro from tblRegistro where Registro = @CodAux";
            cmd.Parameters.AddWithValue("@CodAux", CodAux);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {
                    Check = true;
                }
                else
                {
                    DialogResult confirm = MessageBox.Show("Auxiliar não se encontra no Banco de Dados, deseja continuar?", "Auxiliar não encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                    if (confirm.ToString().ToUpper() == "YES")
                    {
                        Check = true;
                    }
                }

            }

            catch (SqlException)
            {
                this.mensagem = "Erro ao comunicar com Banco de dados - Auxiliar; \n";
            }

            return Check;
        }

        public bool Cadastrar(String Cod_Aux, String Nome_Aux, String Departamento, String Contrato,String Login, String Senha, String Periodo, String Telefone_Aux, String Celular_Aux, String Email_Aux, String RG, String CPF, String Endereco)
        {
            bool temAux = false;
            CadAuxComands ComandAux = new CadAuxComands();
            temAux = ComandAux.verify(Cod_Aux);

            if (temAux == false)
            {
                cmd.CommandText = @"insert into Dados_Aux Values(@Cod_Aux,@Nome_Aux,@Departamento,@Contrato,@Login,@Senha,@Periodo,@Telefone_Aux,@Celular_Aux,@Email_Aux,@RG,@CPF,@Endereco)";
                cmd.Parameters.AddWithValue("@Cod_Aux", Cod_Aux);
                cmd.Parameters.AddWithValue("@Nome_Aux", Nome_Aux);
                cmd.Parameters.AddWithValue("@Departamento", Departamento);
                cmd.Parameters.AddWithValue("@Contrato", Contrato);
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Senha", Senha);
                cmd.Parameters.AddWithValue("@Periodo", Periodo);
                cmd.Parameters.AddWithValue("@Telefone_Aux", Telefone_Aux);
                cmd.Parameters.AddWithValue("@Celular_Aux", Celular_Aux);
                cmd.Parameters.AddWithValue("@Email_Aux", Email_Aux);
                cmd.Parameters.AddWithValue("@RG", RG);
                cmd.Parameters.AddWithValue("@CPF", CPF);
                cmd.Parameters.AddWithValue("@Endereco", Endereco);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    Check = true;
                }


                catch (SqlException)
                {
                    this.mensagem = "Erro ao comunicar com Banco de dados - Auxiliar; \n";
                    Check = false;
                }
            }

            else
            {
                this.mensagem = "Auxiliar ja Cadastrada";
                Check = false;
            }

            return Check;

        }

    }
}
