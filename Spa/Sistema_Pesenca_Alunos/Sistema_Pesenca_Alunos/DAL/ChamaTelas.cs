using Sistema_Pesenca_Alunos.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Pesenca_Alunos.DAL
{
    public class ChamaTelas
    {
        

        public void Ocorrencia(String Nivel)
        {
            Tela_Reg_Ocorrencia Reg_Ocorrencias = new Tela_Reg_Ocorrencia(Nivel);
            Reg_Ocorrencias.Show();
        }

        public void Consulta()
        {
            Tela_Consul Consult = new Tela_Consul();
            Consult.Show();
        }

        public void Cad_Turma()
        {
            Tela_Cad_Turma cad_Turma = new Tela_Cad_Turma();
            cad_Turma.Show();
        }

        public void Reseva_Exp()
        {
            Tela_Reserva_Exp reserva_Exp = new Tela_Reserva_Exp();
            reserva_Exp.Show();
        }

        public void Consult_Reserv_Exp()
        {
            Tela_Consulta_Reserva_Exp Consult_Reserv_Exp = new Tela_Consulta_Reserva_Exp();
            Consult_Reserv_Exp.Show();
        }

        public void Cod_Exp()
        {
            Tela_Cad_exp cad_Exp = new Tela_Cad_exp();
            cad_Exp.Show();
        }

        public void Update_Hora_Saida()
        {
            Tela_Baixa_Alunos Up_Hora_Saida = new Tela_Baixa_Alunos();
            Up_Hora_Saida.Show();
        }
    }
}
