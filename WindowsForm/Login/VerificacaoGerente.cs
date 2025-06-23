using ControleDeProjetos.Model;
using ControleProjetos.Services;
using System;
using System.Windows.Forms;

namespace ControleDeProjetos.WindowsForm.Login
{
    public partial class VerificacaoGerente : Form
    {
        FuncionarioServices _services;
        Form1 _form1;

        public VerificacaoGerente()
        {
            InitializeComponent();
            _services = new FuncionarioServices();
            _form1 = new Form1();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Gerente gerente = new Gerente(0, "", username, password);

            Gerente gerenteLogado;
            gerenteLogado = _services.GetGerenteById(gerente); // gerenteLogado somente com a Id e o Nome do funcionário

            if (gerenteLogado != null)
            {
                
                GerenteMenu gerenteMenu = new GerenteMenu(gerenteLogado);
                gerenteMenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login inválido!");
                txtPassword.Text = "";
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _form1.Show();
            this.Close();
        }
    }
}
