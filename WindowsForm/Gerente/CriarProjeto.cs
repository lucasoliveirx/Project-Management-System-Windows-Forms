using ControleDeProjetos.Model;
using ControleProjetos.Services;
using System;
using System.Windows.Forms;

namespace ControleDeProjetos
{
    public partial class CriarProjeto : Form
    {
        ProjetoServices _projetoServices;
        ClienteServices _clienteServices;
        Gerente gerenteLogado;

        public CriarProjeto(Gerente gerente)
        {
            InitializeComponent();
            gerenteLogado = gerente;
            _projetoServices = new ProjetoServices();
            _clienteServices = new ClienteServices();
            cboxStatus.SelectedIndex = 0;

            // Combo Cliente -> Query para buscar Tabela Cliente -> Exibindo o Empresa do Cliente e Selecionando o Id do Cliente
            cboxCliente.DataSource = _clienteServices.VisualizarEmpresas();
            cboxCliente.DisplayMember = "Empresa";
            cboxCliente.ValueMember = "Id";

            // Alterando valor do txtGerente para o nome do gerente
            txtGerente.Text = gerenteLogado.Nome.ToString();
        }

        private void btnCriarProj_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int clienteId = Convert.ToInt32(cboxCliente.SelectedValue);
            int gerenteId = gerenteLogado.Id; // O projeto vai ser criado com id do gerente logado
            string status = cboxStatus.SelectedItem.ToString();

            Projeto projeto = new Projeto(0, nome, clienteId, gerenteId, null, null, 0, status);
            _projetoServices.CriarProjeto(projeto);

            Cliente cliente = new Cliente(clienteId, null, null, null, null);
            _clienteServices.AtivarCliente(cliente);

            MessageBox.Show("Projeto Criado!");
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
