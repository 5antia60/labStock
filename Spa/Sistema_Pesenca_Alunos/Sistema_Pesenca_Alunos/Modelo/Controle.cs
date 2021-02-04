using Sistema_Pesenca_Alunos.DAL;
using Sistema_Pesenca_Alunos.Telas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistema_Pesenca_Alunos.Modelo
{
    class Controle
    {
        //Cria telas que serão chamadas para cadastros
        Tela_Cad_Clientes NovoCliente = new Tela_Cad_Clientes();
        Tela_Cad_Turma Cad_Turma = new Tela_Cad_Turma();
        CadPresenca Presenca = new CadPresenca();
        RegOcorrencia Ocorrencias = new RegOcorrencia();
        CadTurmaComands Turma = new CadTurmaComands();
        CadProfComands Professor = new CadProfComands();
        CadAuxComands Aux = new CadAuxComands();
        CadAlunComands Aluno = new CadAlunComands();
        Consulta Consult = new Consulta();
        ConsultaReservaExp Consult_Reserva_Exp = new ConsultaReservaExp();
        Reserva_Exp Reserva = new Reserva_Exp();
        CadExperimentos Exp = new CadExperimentos();

        public BindingSource Dados;
        


        //variaveis para confirmação de se ter ou não o Aluno/professor/Turma/Auxiliar no Banco de Dados
        public bool temRA = false;
        public bool temProf = false;
        public bool temTurma = false;
        public bool temAux = false;

        //variavel de mensagem, utiliza-se para escrever uma mensagem X ao usuário do programa
        public bool tem = false;
        public String mensagem = "";
        public String Nivel = "";

        public bool Login (String Login, String Senha)
        {
            LoginSys login = new LoginSys();
            if(login.FazLogin(Login, Senha) == true)
            {
                MessageBox.Show("Logado Com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tem = true;
                this.Nivel = login.Nivel;
            }
            else 
            {
                MessageBox.Show(login.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tem;
        }

        public bool Checar (String RA, String CodProf, String CodAux, String CodTurma, String nivel)
        {
            CadAlunComands ComandAluno = new CadAlunComands();
            CadAuxComands ComandAux = new CadAuxComands();
            CadProfComands ComandProf = new CadProfComands();
            CadTurmaComands ComandTurma = new CadTurmaComands();

            Nivel = nivel;

            temRA = ComandAluno.verify(RA);
            temProf = ComandProf.verify(CodProf);
            temTurma = ComandTurma.verify(CodTurma);
            temAux = ComandAux.verify(CodAux);
            
            if(temRA == true && temProf == true && temTurma == true)
            {
                tem = true;
            }
            else
            {
                tem = false;
            }

            if(!ComandAluno.mensagem.Equals(""))
            {
                if (!RA.Equals(""))
                {

                    DialogResult result = MessageBox.Show(ComandAluno.mensagem + "Deseja Criar?", "Dado não encontrado!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes)
                    {
                        NovoCliente.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Campo RA Vazio", "Necessário preencher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (!ComandAux.mensagem.Equals(""))
            {
                if (!CodAux.Equals(""))
                {
                    DialogResult result = MessageBox.Show("Nenhum auxiliar encontrado com o código digitado...", "Dado não encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (!ComandProf.mensagem.Equals(""))
            {
                if (!CodProf.Equals(""))
                {
                    DialogResult result = MessageBox.Show(ComandProf.mensagem + "Deseja Criar?", "Dado não encontrado!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes)
                    {
                        NovoCliente.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Campo Código Professor Vazio", "Necessário preencher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (!ComandTurma.mensagem.Equals(""))
            {
                if (!CodTurma.Equals(""))
                {
                    DialogResult result = MessageBox.Show(ComandTurma.mensagem + "Deseja Criar?", "Dado não encontrado!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes)
                    {
                        Cad_Turma.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Campo Turma Vazio", "Necessário preencher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return tem;
        }

        public bool adicionarPresenca (String Cod_Prof, String Temp_Prof, String Cod_Aux, String Temp_Aux, String RA, String Temp_Aluno, String Cod_Turma, String Observacao)
        {
            bool tem = false;

            if (Cod_Prof.Equals("") || Temp_Prof.Equals("") || RA.Equals("") || Temp_Aluno.Equals("") || Cod_Turma.Equals(""))
            {
                MessageBox.Show("Há campos vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
              {
              tem = Presenca.Cadastrar(Cod_Prof, Temp_Prof, Cod_Aux, Temp_Aux, RA, Temp_Aluno, Cod_Turma, Observacao);
              this.mensagem = Presenca.mensagem;
            }

            return tem;
        }

        public bool adicionarTurma (String Nome_Materia, String Cod_Turma, String Período)
        {
            bool concluido = false;
            
            if(Nome_Materia.Equals("") || Cod_Turma.Equals("") || Período.Equals(""))
            {
                MessageBox.Show("Há campos vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                
                 concluido = Turma.Cadastrar(Nome_Materia, Cod_Turma, Período);
                 this.mensagem = Turma.mensagem;
                
            }
            return concluido;
        }

        public bool adicionar_Prof(String Cod_prof, String Nome_prof, String Telefone_Prof, String Celular_prof, String Email_prof)
        {
            bool concluido = false;

            if (Cod_prof.Equals("") || Nome_prof.Equals("") || Telefone_Prof.Equals("") || Celular_prof.Equals("") || Email_prof.Equals(""))
            {
                MessageBox.Show("Há campos vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                concluido = Professor.Cadastrar(Cod_prof, Cod_prof, Telefone_Prof, Celular_prof, Email_prof);
                this.mensagem = Professor.mensagem;
            }
            return concluido;
        }

        public bool adicionar_Aux(String Cod_Aux, String Nome_Aux,String Departamento,String Contrato,String Login, String Senha, String ConfSenha, String Periodo, String Telefone_Aux, String Celular_Aux, String Email_Aux, String RG, String CPF, String Endereco)
        {
            bool concluido = false;
                                  
            if (Cod_Aux.Equals("") || Nome_Aux.Equals("") || Departamento.Equals("Selecione") || Telefone_Aux.Equals("") || Contrato.Equals("Selecione") || Periodo.Equals("Selecione") ||Celular_Aux.Equals("") || Email_Aux.Equals("") || Login.Equals("") || Senha.Equals("") || ConfSenha.Equals("") || RG.Equals("") || CPF.Equals("") || Endereco.Equals(""))
            {
                MessageBox.Show("Há campos vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Senha.Equals(ConfSenha))
                {
                    LoginSys login = new LoginSys();
                    if (login.verifyLogin(Login) == false)
                    {
                        concluido = Aux.Cadastrar(Cod_Aux, Cod_Aux, Departamento, Contrato, Login, Senha, Periodo, Telefone_Aux, Celular_Aux, Email_Aux, RG, CPF, Endereco);
                        this.mensagem = Aux.mensagem;
                    }
                    else
                    {
                        MessageBox.Show(login.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    MessageBox.Show("Os campos Senha e Confirmação de senha são diferentes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return concluido;
        }

        public bool adicionar_Aluno(String RA, String Nome_Aluno, String Curso, String Telefone_Aluno, String Celular_Aluno, String Email_Aluno)
        {
            bool concluido = false;


            if (RA.Equals("") || Nome_Aluno.Equals("") || Curso.Equals("") || Telefone_Aluno.Equals("Selecione") || Celular_Aluno.Equals("Selecione") || Celular_Aluno.Equals("") || Email_Aluno.Equals(""))
            {
                MessageBox.Show("Há campos vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                concluido = Aluno.Cadastrar(RA, Nome_Aluno, Curso, Telefone_Aluno, Celular_Aluno, Email_Aluno);
                this.mensagem = Aluno.mensagem;
            }
            return concluido;
        }

        public bool adicionarOcorrencia(String Cod_Prof, String Cod_Aux, String RA, String Cod_Turma, String Ocorrencia)
        {
            bool tem = false;

            if (Cod_Prof.Equals("") || RA.Equals("") ||  Cod_Turma.Equals("") || Ocorrencia.Equals(""))
            {
                MessageBox.Show("Há campos vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tem = Ocorrencias.Registro(Cod_Prof, Cod_Aux, RA, Cod_Turma, Ocorrencia);
                this.mensagem = Ocorrencias.mensagem;
            }
            return tem;
        }

        public bool Reserva_Exp(String RA, String Curso, String Semestre, String Disciplina, String Experimento, String DataEntrada, String HoraEntrada,String Predio, String NSala, String Professor)
        {
            bool tem = false;

            if (RA.Equals("") || Curso.Equals("Selecionar") || Semestre.Equals("Selecionar") || Semestre.Equals("Selecionar Curso") || Disciplina.Equals("Selecionar") || Disciplina.Equals("Selecionar Semestre") || Experimento.Equals("Selecionar") || Experimento.Equals("Selecionar Disciplina") || HoraEntrada.Equals("Selecionar") || Professor.Equals("") || Predio.Equals("") || NSala.Equals(""))
            {
                MessageBox.Show("Há campos vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CadAlunComands ComandAluno = new CadAlunComands();
                ComandAluno.verify(RA);

                if (!ComandAluno.mensagem.Equals(""))
                {                    
                        DialogResult result = MessageBox.Show(ComandAluno.mensagem + "Deseja Criar?", "Dado não encontrado!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result == DialogResult.Yes)
                        {
                            NovoCliente.Show();
                        }                   
                }

                else
                {
                    String Sala = Predio + " " + NSala;
                    if(Reserva.Reservar(RA, Curso, Semestre, Disciplina, Experimento, Professor, Sala, DataEntrada, HoraEntrada) == true)
                    {
                        MessageBox.Show("Reserva Concluída com Exito", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Reserva.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

            return tem;
        }

        public bool Consul_Reserva_Exp(String RA, String Curso, String Semestre, String Disciplina, String Experimento, DateTime Inicio, DateTime Fim)
        {
            bool concluido = false;

            concluido = Consult_Reserva_Exp.Consultar(RA, Curso, Semestre, Disciplina, Experimento, Inicio, Fim);

            if (Consult_Reserva_Exp.mensagem != "" && Consult_Reserva_Exp.Check == false)
            {
                MessageBox.Show(Consult_Reserva_Exp.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Consult_Reserva_Exp.mensagem != "" && Consult_Reserva_Exp.Check == true)
            {
                MessageBox.Show(Consult_Reserva_Exp.mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.Dados = Consult_Reserva_Exp.bind;

            return concluido;
        }

        public bool Consul_Dados_Exp(String RA, DateTime Inicio, DateTime Fim)
        {
            bool concluido = false;
            UpdateHoraSaida dados = new UpdateHoraSaida();

            concluido = dados.Consultar(RA, Inicio, Fim);

            if (dados.mensagem != "" && dados.Check == false)
            {
                MessageBox.Show(dados.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dados.mensagem != "" && dados.Check == true)
            {
                MessageBox.Show(dados.mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.Dados = dados.bind;

            return concluido;
        }

        public bool ModificDados_ExpSaida(String cod_reserva, String Hora, String Min)
        {

            if (Hora.Equals("") || Min.Equals(""))
            {
                MessageBox.Show("Falta preencher o campo Hora ou Minutos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String Hora_Saida = Hora + ":" + Min;
                UpdateHoraSaida update = new UpdateHoraSaida();
                update.AtualizarSaida(cod_reserva, Hora_Saida);

                if (update.Check == true && !update.mensagem.Equals(""))
                {
                    MessageBox.Show(update.mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (update.Check == false && !update.mensagem.Equals(""))
                {
                    MessageBox.Show(update.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            return tem;
        }

        public bool ModificDados_ExpEntrada(String cod_reserva, String Hora, String Min)
        {

            if (Hora.Equals("") || Min.Equals(""))
            {
                MessageBox.Show("Falta preencher o campo Hora ou Minutos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String Hora_Saida = Hora + ":" + Min;
                UpdateHoraSaida update = new UpdateHoraSaida();
                update.AtualizarEntrada(cod_reserva, Hora_Saida);

                if (update.Check == true && !update.mensagem.Equals(""))
                {
                    MessageBox.Show(update.mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (update.Check == false && !update.mensagem.Equals(""))
                {
                    MessageBox.Show(update.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            return tem;
        }

        public String [] Cursos()
        {
            ControleRegExp Curso = new ControleRegExp();
            Curso.Todos_Cursos();
            return Curso.Cursos;
        }

        public String [] SemestresFix()
        {
            ControleRegExp Semestre = new ControleRegExp();
            Semestre.Todos_SemestresFix();
            return Semestre.SemestresFix;
        }

        public List<String> Disciplinas(String Disciplina,String Semestre)
        {
            ControleRegExp Disciplina1 = new ControleRegExp();
            Disciplina1.Todas_Disciplina(Disciplina, Semestre);
            
            if(Disciplina1.mensagem != "" && Disciplina1.Check == false)
            {
                MessageBox.Show(Disciplina1.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Disciplina1.Disciplinas;
        }

        public List<String> Experimentos(String Cursos, String Semestre, String Disciplina)
        {
            ControleRegExp Experimento = new ControleRegExp();
            Experimento.Todos_Experimentos(Cursos, Semestre, Disciplina);

            if (Experimento.mensagem != "" && Experimento.Check == false)
            {
                MessageBox.Show(Experimento.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Experimento.Experimentos;
        }

        public void adicionarExperimento (String Experimento, String Disciplina, String Material)
        {
            if (Disciplina.Equals("") || Experimento.Equals(""))
            {
                MessageBox.Show("Há campos vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Exp.Cad_Todos_Exp(Disciplina, Experimento, Material);

                if(Exp.Check == false && !Exp.mensagem.Equals(""))
                {
                    MessageBox.Show(Exp.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(Exp.Check == true && !Exp.mensagem.Equals(""))
                {
                    MessageBox.Show(Exp.mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
    }
}
