using ControleDeProjetos.Model;
using ControleProjetos.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeProjetos
{
    public partial class RegistrarConsultor : Form
    {
        FuncionarioServices _services;
        public RegistrarConsultor()
        {
            InitializeComponent();
            _services = new FuncionarioServices();
        }

        private void btnRegistrarConsultor_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string especialidade = txtEspecialidade.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Consultor consultor = new Consultor(0, nome, especialidade, username, password);
            _services.InserirConsultor(consultor);

            MessageBox.Show("Consultor Cadastrado!");
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
