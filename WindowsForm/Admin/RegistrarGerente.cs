using ControleDeProjetos.Model;
using ControleProjetos.Services;
using System;
using System.Windows.Forms;

namespace ControleDeProjetos
{
    public partial class RegistrarGerente : Form
    {
        FuncionarioServices _funcionarioServices;
        public RegistrarGerente()
        {
            InitializeComponent();
            _funcionarioServices = new FuncionarioServices();
        }

        private void btnRegistrarGerente_Click(object sender, EventArgs e)
        {
            Gerente gerente = new Gerente(0, txtNome.Text, txtUsername.Text, txtPassword.Text);
            _funcionarioServices.InserirGerente(gerente);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
