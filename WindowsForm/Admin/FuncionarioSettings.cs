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
    public partial class FuncionarioSettings : Form
    {
        FuncionarioServices _funcionarioServices;
        ProjetoServices _projetoServices;
        AlocacoesServices _alocacoes;

        int funcionarioId;
        string statusFuncionario;
        public FuncionarioSettings()
        {
            InitializeComponent();

            _funcionarioServices = new FuncionarioServices();
            _projetoServices = new ProjetoServices();
            _alocacoes = new AlocacoesServices();

            cboxFiltro.SelectedIndex = 0;
        }

        private void dgFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = sender as DataGridView;
            if (dataGrid == null)
                return;

            if (dataGrid.CurrentRow.Cells["Id"].Value.ToString() != "") // Se a coluna ID possui valor, execute o bloco
            {
                funcionarioId = Convert.ToInt32(dataGrid.CurrentRow.Cells["Id"]?.Value);
                statusFuncionario = dataGrid.CurrentRow.Cells["Status"]?.Value.ToString();
                txtFuncionario.Text = dataGrid.CurrentRow.Cells["Nome"]?.Value.ToString();
            }

        }

        private void btnRegistrarConsultor_Click(object sender, EventArgs e)
        {
            RegistrarConsultor registrarConsultor = new RegistrarConsultor();
            registrarConsultor.Show();
        }

        private void btnRegistrarGerente_Click(object sender, EventArgs e)
        {
            RegistrarGerente registrarGerente = new RegistrarGerente();
            registrarGerente.Show();
        }

        private void btnAtivar_Click_1(object sender, EventArgs e)
        {
            if (statusFuncionario == "Inativo")
            {
                _funcionarioServices.AtivarFuncionario(funcionarioId);
                MessageBox.Show($"O funcionário: {txtFuncionario.Text} foi ativado!", "Mensagem: ");
            }
            else
            {
                MessageBox.Show($"O funcionário {txtFuncionario.Text} já está ativo!", "Mensagem: ");
            }
            CarregarFiltros();
        }

        private void btnInativar_Click_1(object sender, EventArgs e)
        {
            if (cboxFiltro.SelectedIndex == 0)
            {
                bool verificacao = _alocacoes.VerificarProjetosAtivosConsultor(funcionarioId);

                if (verificacao)
                {
                    MessageBox.Show("Não é possível inativar um Consultor com projetos ativos", "Mensagem: ");
                }
                else
                {
                    _funcionarioServices.InativarFuncionario(funcionarioId);
                    MessageBox.Show($"O funcionário: {txtFuncionario.Text} foi inativado!", "Mensagem: ");
                }
            }

            if (cboxFiltro.SelectedIndex == 1)
            {
                bool verificacao = _projetoServices.ProjetosAtivosGerente(funcionarioId);

                if (verificacao)
                {
                    MessageBox.Show("Não é possível inativar um Gerente com projetos ativos", "Mensagem: ");
                }
                else
                {
                    _funcionarioServices.InativarFuncionario(funcionarioId);
                    MessageBox.Show($"O funcionário: {txtFuncionario.Text} foi inativado!", "Mensagem: ");
                }
            }
            CarregarFiltros();
        }

        public void CarregarFiltros()
        {
            switch (cboxFiltro.SelectedIndex)
            {
                case 0:
                    string cargo = "Consultor";
                    dgFuncionarios.DataSource = _funcionarioServices.ListarFuncionarios(cargo);
                    break;
                case 1:
                    string cargo1 = "Gerente";
                    dgFuncionarios.DataSource = _funcionarioServices.ListarFuncionarios(cargo1);
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void cboxFiltro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CarregarFiltros();
        }
    }
}
