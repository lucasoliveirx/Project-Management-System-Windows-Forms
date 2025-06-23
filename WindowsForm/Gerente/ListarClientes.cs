using ControleProjetos.Services;
using System;
using System.Windows.Forms;

namespace ControleDeProjetos
{
    public partial class ListarClientes : Form
    {
        ClienteServices _clienteServices;

        string filtroTodos = "";
        string filtroClientesAtivos = "WHERE STATUS = 1";
        string filtroClientesInativos = "WHERE STATUS = 0";

        public ListarClientes()
        {
            InitializeComponent();

            _clienteServices = new ClienteServices();

            cboxFiltro.SelectedIndex = 0;
            AjustarColunas();
        }

        public void CarregarFiltros()
        {
            switch (cboxFiltro.SelectedIndex)
            {
                case 0:
                    dgCliente.DataSource = _clienteServices.VisualizarClientes(filtroTodos);
                    break;
                case 1:
                    dgCliente.DataSource = _clienteServices.VisualizarClientes(filtroClientesAtivos);
                    break;
                case 2:
                    dgCliente.DataSource = _clienteServices.VisualizarClientes(filtroClientesInativos);
                    break;
            }
        }

        public void AjustarColunas()
        {
            dgCliente.Columns[0].Width = 40;
            dgCliente.Columns[1].Width = 210;
            dgCliente.Columns[2].Width = 250;
            dgCliente.Columns[3].Width = 170;
            dgCliente.Columns[4].Width = 60;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarFiltros();
        }
    }
}
