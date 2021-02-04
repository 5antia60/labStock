using LabEstoque.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEstoque.Modelo
{
    public class ControleRegistro
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar(String Registro)
        {
            RegistroDAO loginDao = new RegistroDAO();
            tem = loginDao.verificarRegistro(Registro);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
    }
}
