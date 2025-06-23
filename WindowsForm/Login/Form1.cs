using ControleDeProjetos.WindowsForm.Login;
using System;
using System.Windows.Forms;

namespace ControleDeProjetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerente_Click(object sender, EventArgs e)
        {
            VerificacaoGerente verificacaoGerente = new VerificacaoGerente();
            verificacaoGerente.Show();
            

            this.Hide();
        }

        private void btnConsultor_Click(object sender, EventArgs e)
        {
            VerificacaoConsultor verificacaoConsultor = new VerificacaoConsultor();
            verificacaoConsultor.Show();

            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            VerificacaoAdmin verificacaoAdmin = new VerificacaoAdmin();
            verificacaoAdmin.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
