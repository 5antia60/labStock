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
    public partial class Tela_Cad_exp : Form
    {
        public Tela_Cad_exp()
        {
            InitializeComponent();
            Controle controle = new Controle();

        }

        private void Tela_Cad_exp_Load(object sender, EventArgs e)
        {

        }

        private void btCadExp_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.adicionarExperimento(txbDiscilpina.Text, txbExperimento.Text, txbMaterial.Text);
        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
