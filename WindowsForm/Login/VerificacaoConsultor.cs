using ControleDeProjetos.Model;
using ControleProjetos.Services;
using System;
using System.Windows.Forms;

namespace ControleDeProjetos.WindowsForm.Login
{
    public partial class VerificacaoConsultor : Form
    {
        FuncionarioServices _services;
        Form1 _form1;
        public VerificacaoConsultor()
        {
            InitializeComponent();
            _services = new FuncionarioServices();
            _form1 = new Form1();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Consultor consultor = new Consultor(0, "", "", username, password);
            

            // consultorLogado vai buscar a Id do consultor com o username e password
            Consultor consultorLogado;
            consultorLogado = _services.GetConsultorById(consultor);

            if (consultorLogado != null)
            {
                ProjetosAlocados projetosAlocados = new ProjetosAlocados(consultorLogado);
                projetosAlocados.Show();

                this.Hide();
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
