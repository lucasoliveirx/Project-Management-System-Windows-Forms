using ControleDeProjetos.Model;
using ControleProjetos.Data;
using System.Data;

namespace ControleProjetos.Repository
{
    public class AlocacoesRepository
    {
        DataContext _context;
        public AlocacoesRepository()
        {
            _context = new DataContext();
        }


        // 2. Alocar Consultor no Projeto Selecionado
        public void AlocarConsultorProjetoRepository(Projeto projeto, Consultor consultor)
        {
            string query = $"INSERT INTO ProjetoConsultores (ProjetoId, ConsultorId) VALUES ('{projeto.Id}', '{consultor.Id}')";
            _context.ExecuteQuery(query);
            
        }

        // 1. Verificar se o Consultor já está Alocado no Projeto
        public bool VerificarConsultorProjetoRepository(Projeto projeto, Consultor consultor)
        {
            string query = $"SELECT * FROM ProjetoConsultores WHERE ProjetoId = '{projeto.Id}' AND ConsultorId = {consultor.Id}";

            DataSet dataSet = _context.ReadQuery(query);
            int consultorRow = dataSet.Tables[0].Rows.Count;

            if (consultorRow > 0)
            {
                return true; // True -> Consultor já está Alocado no Projeto
            }
            else
            {
                return false; // False -> Consultor não está Alocado no Projeto
            }
        }

        // 3. Verificar Quantidade Projetos Ativos Alocados por Consultor
        public DataSet QuantidadeProjetosPorConsultorRepository()
        {
            string query = $"SELECT PC.ConsultorId, F.Nome AS NomeConsultor, COUNT(DISTINCT PC.ProjetoId) AS TotalProjetos FROM ProjetoConsultores PC JOIN Projetos P ON PC.ProjetoId = P.Id JOIN Funcionarios F ON PC.ConsultorId = F.Id WHERE P.Status IN ('Em Planejamento', 'Em Execução', 'Paralisado') GROUP BY PC.ConsultorId, F.Nome ORDER BY TotalProjetos DESC";

            return _context.ReadQuery(query);
        }

        // 4. Buscar Projetos Ativos de Funcionários
        public DataTable BuscarProjetosAtivosRepository(int funcionarioId)
        {
            string query = $"SELECT PC.ProjetoId FROM ProjetoConsultores PC JOIN Projetos P ON PC.ProjetoId = P.Id WHERE PC.ConsultorId = {funcionarioId} AND P.Status IN ('Em Planejamento', 'Em Execução', 'Paralisado')";
            return _context.ReadQuery(query).Tables[0];
        }

        // 5. Atualizar Carga Horária Semanal Consultor por Projeto
        public void AtualizarCargaHorariaSemanalRepository(Projeto projeto, Consultor consultor, int cargaHorariaSemanal)
        {
            string query = $"UPDATE ProjetoConsultores SET CargaHorariaSemanal = '{cargaHorariaSemanal}' WHERE ProjetoId = '{projeto.Id}' AND ConsultorId = '{consultor.Id}'";
            _context.ExecuteQuery(query);
        }


        // Gerar Relatório
        public DataTable GerarRelatorioRepository(string filtroConsultor, string filtroStatus)
        {
            string query = $"SELECT F.Nome AS Consultor, F.Especialidade AS Especialidade, P.Nome AS Projeto, C.Empresa AS Empresa, FG.Nome AS Gerente, CONCAT(PC.CargaHorariaSemanal, 'h') AS CargaHorariaSemanal, P.Status AS Status, FORMAT(P.DataInicio, 'dd/MM/yyyy') AS DataInicio, FORMAT(P.DataFim, 'dd/MM/yyyy') AS DataFim FROM ProjetoConsultores PC JOIN Funcionarios F ON PC.ConsultorId = F.Id JOIN Projetos P ON PC.ProjetoId = P.Id JOIN Funcionarios FG ON P.GerenteId = FG.Id JOIN Clientes C ON P.ClienteId = C.Id {filtroConsultor} {filtroStatus} ORDER BY F.Nome, P.Nome;";

            DataSet dataSet = _context.ReadQuery(query);
            DataTable dataTable = dataSet.Tables[0];

            return dataTable;
        }
    }
}