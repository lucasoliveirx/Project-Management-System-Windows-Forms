using System;
using System.Windows.Forms;

namespace ControleDeProjetos.WindowsForm.Login
{
    public partial class VerificacaoAdmin : Form
    {
        public VerificacaoAdmin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin")
            {
                if (password == "!")
                {
                    
                    FuncionarioSettings funcionarioSettings = new FuncionarioSettings();
                    funcionarioSettings.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login inválido!", "Mensagem: ");
                    txtPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("Login inválido!", "Mensagem: ");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
        }
    }
}
