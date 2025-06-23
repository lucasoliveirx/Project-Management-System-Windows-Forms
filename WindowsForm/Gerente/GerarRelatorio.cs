using ControleDeProjetos.Model;
using ControleProjetos.Services;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ControleDeProjetos
{
    public partial class GerarRelatorio : Form
    {
        Gerente _gerenteLogado;
        AlocacoesServices _alocacoes;
        FuncionarioServices _funcionarioServices;

        public GerarRelatorio(Gerente gerente)
        {
            InitializeComponent();

            _alocacoes = new AlocacoesServices();
            _funcionarioServices = new FuncionarioServices();

            _gerenteLogado = gerente;
            txtGerente.Text = _gerenteLogado.Nome;

            ComboBoxConsultoresConfig();

            cboxStatus.SelectedIndex = 0;

            AjustarLarguraColuna();

        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
            string caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "RelatorioProjetos.pdf");

            try
            {
                PdfWriter.GetInstance(pdfDoc, new FileStream(caminho, FileMode.Create));
                pdfDoc.Open();

                // Título
                Paragraph titulo = new Paragraph("Relatório de Projetos");
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 20f;
                pdfDoc.Add(titulo);

                // Criar tabela PDF com o mesmo número de colunas do DataGridView
                PdfPTable pdfTable = new PdfPTable(dgProjeto.Columns.Count);

                foreach (DataGridViewColumn column in dgProjeto.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in dgProjeto.Rows)
                {
                    if (row.IsNewRow) continue;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value?.ToString() ?? "");
                    }
                }

                pdfDoc.Add(pdfTable);
                MessageBox.Show("PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar PDF: " + ex.Message);
            }
            finally
            {
                pdfDoc.Close();
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregarFiltro()
        {
            string _statusAll = "";
            string _statusPlanejamento = "AND P.Status = 'Em Planejamento'";
            string _statusExecucao = "AND P.Status = 'Em Execução'";
            string _statusParalisado = "AND P.Status = 'Paralisado'";
            string _statusEncerrado = "AND P.Status = 'Encerrado'";

            switch (cboxConsultor.SelectedIndex)
            {
                case 0:
                    switch (cboxStatus.SelectedIndex)
                    {
                        case 0:
                            {
                                dgProjeto.DataSource = _alocacoes.GerarRelatorio("", _statusAll);
                                break;
                            }
                        case 1:
                            {
                                dgProjeto.DataSource = _alocacoes.GerarRelatorio("", _statusPlanejamento);
                                break;
                            }
                        case 2:
                            {
                                dgProjeto.DataSource = _alocacoes.GerarRelatorio("", _statusExecucao);
                                break;
                            }
                        case 3:
                            {
                                dgProjeto.DataSource = _alocacoes.GerarRelatorio("", _statusParalisado);
                                break;
                            }
                        case 4:
                            {
                                dgProjeto.DataSource = _alocacoes.GerarRelatorio("", _statusEncerrado);
                                break;
                            }
                    }
                    break;

                default:
                    {
                        string consultorId = cboxConsultor.SelectedValue.ToString();
                        string filtroConsultor = $"WHERE PC.ConsultorId = {consultorId}";

                        switch (cboxStatus.SelectedIndex)
                        {
                            case 0:
                                {
                                    dgProjeto.DataSource = _alocacoes.GerarRelatorio(filtroConsultor, _statusAll);
                                    break;
                                }
                            case 1:
                                {
                                    dgProjeto.DataSource = _alocacoes.GerarRelatorio(filtroConsultor, _statusPlanejamento);
                                    break;
                                }
                            case 2:
                                {
                                    dgProjeto.DataSource = _alocacoes.GerarRelatorio(filtroConsultor, _statusExecucao);
                                    break;
                                }
                            case 3:
                                {
                                    dgProjeto.DataSource = _alocacoes.GerarRelatorio(filtroConsultor, _statusParalisado);
                                    break;
                                }
                            case 4:
                                {
                                    dgProjeto.DataSource = _alocacoes.GerarRelatorio(filtroConsultor, _statusEncerrado);
                                    break;
                                }
                        }
                        break;
                    }
            }
        }
        private void cboxConsultor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CarregarFiltro();
        }

        private void cboxStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CarregarFiltro();
        }

        public void ComboBoxConsultoresConfig()
        {
            // Criando nova linha com valor (Id = 0 ; Nome = Todos os Consulores)
            DataTable consultoresTable = _funcionarioServices.ListarConsultores();
            DataRow newRow = consultoresTable.NewRow();
            newRow["Id"] = 0;
            newRow["Nome"] = "Todos os Consultores";

            // Inserir linha na tabela
            consultoresTable.Rows.InsertAt(newRow, 0);

            cboxConsultor.DataSource = consultoresTable;

            cboxConsultor.SelectedIndex = 0;
            cboxConsultor.DisplayMember = "Nome";
            cboxConsultor.ValueMember = "Id";
        }

        public void AjustarLarguraColuna()
        {
            dgProjeto.Columns[0].Width = 150;
            dgProjeto.Columns[1].Width = 200;
            dgProjeto.Columns[2].Width = 200;
            dgProjeto.Columns[3].Width = 150;
            dgProjeto.Columns[4].Width = 150;
            dgProjeto.Columns[5].Width = 120;
            dgProjeto.Columns[6].Width = 60;
            dgProjeto.Columns[7].Width = 80;
            dgProjeto.Columns[8].Width = 80;
        }
    }
}

