using Sistema_Pesenca_Alunos.DAL;
using Sistema_Pesenca_Alunos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Pesenca_Alunos.Telas
{
    public partial class Tela_Reserva_Exp : Form
    {        
        public Tela_Reserva_Exp()
        {
            InitializeComponent();

            Controle controle = new Controle();
            cbCurso.DataSource = controle.Cursos();            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            cbExperimento.DataSource = controle.Experimentos(cbCurso.Text, cbSemestre.Text,cbDisciplina.Text);            
        }

        private void Tela_Reserva_Exp_Load(object sender, EventArgs e)
        {

        }

        private void cbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            cbDisciplina.DataSource = controle.Disciplinas(cbCurso.Text, cbSemestre.Text);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Reserva_Exp(txbRA.Text, cbCurso.Text, cbSemestre.Text, cbDisciplina.Text, cbExperimento.Text, txbData.Text, txbHora.Text,cbPredio.Text,mtbSala.Text,txbNomeProf.Text);
        }

        private void cbExperimento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
