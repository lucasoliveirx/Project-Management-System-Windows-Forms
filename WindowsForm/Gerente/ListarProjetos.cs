using ControleProjetos.Services;
using System;
using System.Windows.Forms;

namespace ControleDeProjetos
{
    public partial class ListarProjetos : Form
    {
        ProjetoServices _projetoServices;
        public ListarProjetos()
        {
            InitializeComponent();
            _projetoServices = new ProjetoServices();

            cboxFiltro.SelectedIndex = 0;
            AjustarLarguraColuna();
        }

        private void cboxFiltro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CarregarFiltro();
        }

        public void CarregarFiltro()
        {
            string statusAll = "";
            string statusPlanejamento = "WHERE P.Status = 'Em Planejamento'";
            string statusExecucao = "WHERE P.Status = 'Em Execução'";
            string statusParalisado = "WHERE P.Status = 'Paralisado'";
            string statusEncerrado = "WHERE P.Status = 'Encerrado'";

            switch (cboxFiltro.SelectedIndex)
            {
                case 0:
                    dgProjeto.DataSource = _projetoServices.ListarProjetos(statusAll);
                    break;
                case 1:
                    dgProjeto.DataSource = _projetoServices.ListarProjetos(statusPlanejamento);
                    break;
                case 2:
                    dgProjeto.DataSource = _projetoServices.ListarProjetos(statusExecucao);
                    break;
                case 3:
                    dgProjeto.DataSource = _projetoServices.ListarProjetos(statusParalisado);
                    break;
                case 4:
                    dgProjeto.DataSource = _projetoServices.ListarProjetos(statusEncerrado);
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AjustarLarguraColuna()
        {
            dgProjeto.Columns[0].Width = 30;
            dgProjeto.Columns[1].Width = 200;
            dgProjeto.Columns[2].Width = 200;
            dgProjeto.Columns[3].Width = 120;
            dgProjeto.Columns[4].Width = 120;
            dgProjeto.Columns[5].Width = 60;
            dgProjeto.Columns[6].Width = 80;
            dgProjeto.Columns[7].Width = 80;
        }
    } 
}
