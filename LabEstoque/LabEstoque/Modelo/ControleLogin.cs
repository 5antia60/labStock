using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEstoque
{
    class ControleLogin
    {
        public bool tem;
        public String mensagem = "";
        public String Nivel = "";

        public bool acessar(String Login, String Senha)
        {
            TelaConsultaInicial loginDao = new TelaConsultaInicial();
            tem = loginDao.verificarLogin(Login, Senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            this.Nivel = loginDao.nivel;
            return tem;
        }

        public string cadastrar(String Nome, String Telefone, String RG, String CPF, String Endereço, String Login, String Senha, String confSenha, String Status)
        {
            TelaConsultaInicial loginDao = new TelaConsultaInicial();
            this.mensagem = loginDao.cadastrar(Nome, Telefone, RG, CPF, Endereço, Login, Senha, confSenha, Status);
            if (loginDao.tem) //a mensagem que vai vir e de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
