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
    public partial class RegistrarCliente : Form
    {
        ClienteServices _services;
        public RegistrarCliente()
        {
            InitializeComponent();
            _services = new ClienteServices();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            string clienteNome = txtNome.Text;
            string clienteEmpresa = txtEmpresa.Text;
            string clienteCnpj = txtCnpj.Text;

            Cliente cliente = new Cliente(0, clienteNome, clienteEmpresa, clienteCnpj, null);

            _services.InsertCliente(cliente);

            MessageBox.Show("Cliente Cadastrado!");
            this.Close();
        }
    }
}
