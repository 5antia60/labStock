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
    public partial class Tela_Reg_Ocorrencia : Form
    {
        public String nivel = "";
        public Tela_Reg_Ocorrencia(String Nivel)
        {
            nivel = Nivel;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btRegistrarOc_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            controle.Checar(txbRA.Text, txbCodProf.Text, txbCod_Aux.Text, txbTurma.Text, nivel);

            if (controle.tem == true)
            {
                if (controle.adicionarOcorrencia(txbCodProf.Text, txbCod_Aux.Text, txbRA.Text, txbTurma.Text, txbOcorrencia.Text) == true)
                {
                    MessageBox.Show("Ocorrencia Registrada", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbRA.Text = "";
                    txbOcorrencia.Text = "";
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

        private void txbTurma_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Reg_Ocorrencia_Load(object sender, EventArgs e)
        {

        }
    }
}
