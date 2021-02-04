using System;
using Sistema_Pesenca_Alunos.Modelo;
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
    public partial class Tela_Cad_Turma : Form
    {
        public bool concluido = false;

        public Tela_Cad_Turma()
        {
            InitializeComponent();
                    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            concluido = controle.adicionarTurma(txbNome_materia.Text, txbCod_Turma.Text, txbPeriodo.Text);

            if (concluido == true)
            {

                MessageBox.Show("Turma Registrado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                if (!controle.mensagem.Equals(""))
                {
                    MessageBox.Show(controle.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
