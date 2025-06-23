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
    public partial class GestaoDeProjetos : Form
    {
        Gerente _gerenteLogado;
        ProjetoServices _projetoServices;
        FuncionarioServices _funcionarioServices;
        AlocacoesServices _alocacoesServices;
        ClienteServices _clienteServices;

        public GestaoDeProjetos(Gerente gerente)
        {
            InitializeComponent();
            _gerenteLogado = gerente;
            _projetoServices = new ProjetoServices();
            _funcionarioServices = new FuncionarioServices();
            _alocacoesServices = new AlocacoesServices();
            _clienteServices = new ClienteServices();

            // Texto do Usuario Logado
            txtUserLogado.Text = _gerenteLogado.Nome;

            // DataGrid -> Conexão com BD + Largura das Colunas
            cboxFiltro.SelectedIndex = 0;
            AjustarLarguraColuna();


            // Combo Box -> Listar Consultores SQL
            cboxConsultor.DataSource = _funcionarioServices.ListarConsultores();

            cboxConsultor.DisplayMember = "Nome";
            cboxConsultor.ValueMember = "Id";

        }

        private void dgProjeto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = sender as DataGridView;
            if (dataGrid == null)
                return;

            if (dataGrid.CurrentRow.Cells["Id"].Value.ToString() != "") // Se a coluna ID possui valor, execute o bloco
            {
                txtProjetoId.Text = dataGrid.CurrentRow.Cells["Id"]?.Value.ToString();
                txtProjeto.Text = dataGrid.CurrentRow.Cells["Projeto"]?.Value.ToString(); //transformou o datagrid na coluna Id do banco de dados
                txtEmpresa.Text = dataGrid.CurrentRow.Cells["Empresa"]?.Value.ToString();
                txtGerente.Text = dataGrid.CurrentRow.Cells["Gerente"]?.Value.ToString();
                txtStatus.Text = dataGrid.CurrentRow.Cells["Status"]?.Value.ToString();
                txtDataInicio.Text = dataGrid.CurrentRow.Cells["DataInicio"]?.Value.ToString();
                txtDataFim.Text = dataGrid.CurrentRow.Cells["DataFim"]?.Value.ToString();
            }
        }

        private void btnInserirConsultor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Projeto: {txtProjeto.Text} \n\nDeseja inserir: {cboxConsultor.Text}?", "Mensagem: ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int projetoId = Convert.ToInt32(txtProjetoId.Text);
                int consultorId = Convert.ToInt32(cboxConsultor.SelectedValue);
                Projeto projeto = new Projeto(projetoId, null, 0, 0, null, null, 0, null);
                Consultor consultor = new Consultor(consultorId, null, null, null, null);

                bool checkConsultorAtivo = _funcionarioServices.VerificarStatusConsultor(consultor);
                if (checkConsultorAtivo)
                {
                    bool checkConsultor = _alocacoesServices.VerificarConsultorProjeto(projeto, consultor);
                    if (checkConsultor)
                    {
                        MessageBox.Show("Consultor já está alocado no projeto!", "Mensagem: ERRO");
                    }
                    else
                    {
                        bool checkProjeto = _projetoServices.VerificarProjetoAtivo(projeto);
                        if (checkProjeto)
                        {
                            _alocacoesServices.AlocarConsultorProjeto(projeto, consultor);

                            _alocacoesServices.AtualizarCargaHorariaConsultor();

                            _projetoServices.AtualizarHorasEstimadas();

                            MessageBox.Show("Consultor inserido no projeto!", "Mensagem: ");

                            CarregarFiltro();
                        }
                        else
                        {
                            MessageBox.Show("Não é possível alocar um consultor em PROJETO INATIVO!", "Mensagem: ERRO");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Não é possível alocar um CONSULTOR INATIVO em um projeto!", "Mensagem: ERRO");
                }
            }

        }

        private void btnEncerrarProj_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show($"Projeto: {txtProjeto.Text} \n\nDeseja encerrá-lo?", "Mensagem: ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int projetoId = Convert.ToInt32(txtProjetoId.Text);
                Projeto projeto = new Projeto(projetoId, null, 0, 0, null, null, 0, null);

                _projetoServices.EncerrarProjeto(projeto);

                _projetoServices.ZerarHorasEstimadas(projeto);

                _alocacoesServices.AtualizarCargaHorariaConsultor();

                _projetoServices.AtualizarHorasEstimadas();

                // Inativar Cliente caso não tenha nenhum projeto ativo
                int clienteId = _projetoServices.GetClienteIdByProjetoId(projeto);
                Cliente cliente = new Cliente(clienteId, null, null, null, null);

                bool verificacao = _projetoServices.ProjetosAtivosCliente(cliente);

                if (verificacao == false)
                {
                    _clienteServices.DesativarCliente(cliente);
                    MessageBox.Show($"Projeto Encerrado! \n\nAviso: \nO cliente: [{txtEmpresa.Text}] foi Inativado pois não possui nenhum projeto Ativo.", "Mensagem: ");
                }
                else
                {
                    MessageBox.Show("Projeto Encerrado!", "Mensagem: ");
                }

                CarregarFiltro(); // Refresh
            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregarFiltro()
        {
            string _statusAll = "";
            string _statusPlanejamento = "WHERE P.Status = 'Em Planejamento'";
            string _statusExecucao = "WHERE P.Status = 'Em Execução'";
            string _statusParalisado = "WHERE P.Status = 'Paralisado'";
            string _statusEncerrado = "WHERE P.Status = 'Encerrado'";

            switch (cboxFiltro.SelectedIndex)
            {

                case 0:
                    dgProjeto.DataSource = _projetoServices.ListarProjetos(_statusAll);
                    break;
                case 1:
                    dgProjeto.DataSource = _projetoServices.ListarProjetos(_statusPlanejamento);
                    break;
                case 2:
                    dgProjeto.DataSource = _projetoServices.ListarProjetos(_statusExecucao);
                    break;
                case 3:
                    dgProjeto.DataSource = _projetoServices.ListarProjetos(_statusParalisado);
                    break;
                case 4:
                    dgProjeto.DataSource = _projetoServices.ListarProjetos(_statusEncerrado);
                    break;
            }
        }

        public void AjustarLarguraColuna()
        {
            dgProjeto.Columns[0].Width = 30;
            dgProjeto.Columns[1].Width = 200;
            dgProjeto.Columns[2].Width = 200;
            dgProjeto.Columns[3].Width = 120;
            dgProjeto.Columns[4].Width = 120;
            dgProjeto.Columns[5].Width = 120;
            dgProjeto.Columns[6].Width = 80;
            dgProjeto.Columns[7].Width = 80;
        }

        private void cboxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarFiltro();
        }
    }
}
