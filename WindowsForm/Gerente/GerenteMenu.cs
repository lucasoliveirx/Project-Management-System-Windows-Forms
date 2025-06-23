using ControleDeProjetos.Model;
using System;
using System.Windows.Forms;

namespace ControleDeProjetos
{
    public partial class GerenteMenu : Form
    {
        Gerente gerenteLogado;
        public GerenteMenu(Gerente gerente)
        {
            InitializeComponent();
            gerenteLogado = gerente;
            txtGerente.Text = gerenteLogado.Nome;
        }

        private void btnCriarProj_Click(object sender, EventArgs e)
        {
            CriarProjeto criarProjeto = new CriarProjeto(gerenteLogado);
            criarProjeto.Show();
        }

        private void btnGestaoProj_Click(object sender, EventArgs e)
        {
            GestaoDeProjetos gestaoDeProjetos = new GestaoDeProjetos(gerenteLogado);
            gestaoDeProjetos.Show();
        }

        private void btnListarProj_Click(object sender, EventArgs e)
        {
            ListarProjetos listarProjetos = new ListarProjetos();
            listarProjetos.Show();
        }

        private void btnRegistrarConsultor_Click(object sender, EventArgs e)
        {
            RegistrarConsultor registrarConsultor = new RegistrarConsultor();
            registrarConsultor.Show();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            GerarRelatorio gerarRelatorio = new GerarRelatorio(gerenteLogado);
            gerarRelatorio.Show();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            RegistrarCliente registrarCliente = new RegistrarCliente();
            registrarCliente.Show();
        }

        private void btnListarCliente_Click(object sender, EventArgs e)
        {
            ListarClientes listarClientes = new ListarClientes();
            listarClientes.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
