using ControleDeProjetos.Model;
using ControleProjetos.Services;
using System;
using System.Windows.Forms;

namespace ControleDeProjetos
{
    public partial class ProjetosAlocados : Form
    {
        AlocacoesServices _alocacoes;
        Consultor _consultorLogado;
        public ProjetosAlocados(Consultor consultor)
        {
            InitializeComponent();
            _alocacoes = new AlocacoesServices();
            _consultorLogado = consultor;

            txtUserLogado.Text = _consultorLogado.Nome;

            cboxFiltro.SelectedIndex = 0;
            AjustarLarguraColuna();
        }

        public void CarregarFiltro()
        {
            string _statusAll = "";
            string _statusPlanejamento = "AND P.Status = 'Em Planejamento'";
            string _statusExecucao = "AND P.Status = 'Em Execução'";
            string _statusParalisado = "AND P.Status = 'Paralisado'";
            string _statusEncerrado = "AND P.Status = 'Encerrado'";
            string filtroConsultor = $"AND PC.ConsultorId = {_consultorLogado.Id}";

            switch (cboxFiltro.SelectedIndex)
            {
                case 0:
                    dgProjeto.DataSource = _alocacoes.GerarRelatorio(filtroConsultor, _statusAll);
                    break;
                case 1:
                    dgProjeto.DataSource = _alocacoes.GerarRelatorio(filtroConsultor, _statusPlanejamento);
                    break;
                case 2:
                    dgProjeto.DataSource = _alocacoes.GerarRelatorio(filtroConsultor, _statusExecucao);
                    break;
                case 3:
                    dgProjeto.DataSource = _alocacoes.GerarRelatorio(filtroConsultor, _statusParalisado);
                    break;
                case 4:
                    dgProjeto.DataSource = _alocacoes.GerarRelatorio(filtroConsultor, _statusEncerrado);
                    break;
            }
        }

        public void AjustarLarguraColuna()
        {
            dgProjeto.Columns[0].Visible = false;
            dgProjeto.Columns[1].Visible = false;
            dgProjeto.Columns[2].Width = 200;
            dgProjeto.Columns[3].Width = 150;
            dgProjeto.Columns[4].Width = 150;
            dgProjeto.Columns[5].Width = 120;
            dgProjeto.Columns[6].Width = 60;
            dgProjeto.Columns[7].Width = 80;
            dgProjeto.Columns[8].Width = 80;
        }

        private void cboxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarFiltro();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
