using ControleDeProjetos.Model;
using ControleProjetos.Data;
using System.Data;
using System.Xml;

namespace ControleProjetos.Repository
{
    public class ProjetoRepository
    {
        DataContext _context;
        public ProjetoRepository()
        {
            _context = new DataContext();
        }


        // Criar Projeto
        public void InserirProjetoRepository(Projeto projeto)
        {
            string query = $"INSERT INTO Projetos (Nome, ClienteId, GerenteId, DataInicio, Status) VALUES ('{projeto.Nome}', '{projeto.Cliente.Id}', '{projeto.GerenteResponsavel.Id}', GETDATE(), '{projeto.Status}')";
            _context.ExecuteQuery(query);
        }

        // Listar Todos os Projetos (Planilha)
        public DataTable ListarProjetosRepository(string filtroStatus)
        {
            string query = $"SELECT P.Id AS ID, P.Nome AS Projeto, C.Empresa AS Empresa, F.Nome AS Gerente, CONCAT(P.HorasEstimadasConsultores, 'h') AS HorasConsultores, P.STATUS AS Status, FORMAT(P.DataInicio, 'dd/MM/yyyy') AS DataInicio, FORMAT(P.DataFim, 'dd/MM/yyyy') AS DataFim FROM Projetos P JOIN Clientes C ON P.ClienteId = C.Id JOIN Funcionarios F ON P.GerenteId = F.Id {filtroStatus} ORDER BY P.Id";

            DataTable projetoTable = _context.ReadQuery(query).Tables[0];
            return projetoTable;
        }

        // Verificar se o Projeto Está Ativo
        public DataTable VerificarProjetoAtivoRepository(Projeto projeto)
        {
            string query = $"SELECT * FROM Projetos WHERE Id = '{projeto.Id}' AND Status IN ('Em Planejamento', 'Em Execução', 'Paralisado')";

            DataTable dataTable = _context.ReadQuery(query).Tables[0];
            return dataTable;
        }

        // Atualizar  Total de Horas Estimadas Dos Consultores e Atualizar na Tabela
        public void AtualizarHorasEstimadasRepository()
        {
            string query = $"UPDATE P SET P.HorasEstimadasConsultores = T.TotalHoras FROM Projetos P JOIN (SELECT A.ProjetoId, SUM(A.CargaHorariaSemanal) AS TotalHoras FROM ProjetoConsultores A JOIN Projetos P2 ON A.ProjetoId = P2.Id WHERE P2.Status IN ('Em Planejamento', 'Em Execução', 'Paralisado') GROUP BY A.ProjetoId) T ON P.Id = T.ProjetoId WHERE P.Status IN ('Em Planejamento', 'Em Execução', 'Paralisado');";
            _context.ExecuteQuery(query);
        }


        // Encerrar Projeto
        public void EncerrarProjetoRepository(Projeto projeto)
        {
            string query = $"UPDATE Projetos SET Status = 'Encerrado', DataFim = GETDATE() WHERE Id = '{projeto.Id}'";
            _context.ExecuteQuery(query);
        }

        // Zerar HorasEstimadas de Projetos Inativos
        public void ZerarHorasEstimadasRepository(Projeto projeto)
        {
            string query = $"UPDATE Projetos SET HorasEstimadasConsultores = 0 WHERE Id = '{projeto.Id}';";
            _context.ExecuteQuery(query);
        }

        // Selecionar ClienteId pelo Projeto Id
        public DataTable GetClienteIdByProjetoIdRepository(Projeto projeto)
        {
            string query = $"SELECT ClienteId FROM PROJETOS WHERE Id = {projeto.Id}";
            DataTable dataTable = _context.ReadQuery(query).Tables[0];
            return dataTable;
        }

        // Verificar se o Cliente Possui Projetos Ativos
        public DataTable ProjetosAtivosClientesRepository(Cliente cliente)
        {
            string query = $"SELECT Nome, Status FROM PROJETOS WHERE Status IN ('Em Planejamento', 'Em Execução', 'Paralisado') AND ClienteId = {cliente.Id};";
            DataTable dataTable = _context.ReadQuery(query).Tables[0];
            return dataTable;
        }

        // Verificar se Gerente Possui Projetos Ativos
        public DataTable VerificarProjetosAtivosGerenteRepository(int gerenteId)
        {
            string query = $"SELECT Nome FROM Projetos WHERE GerenteId = {gerenteId} AND Status IN ('Em Planejamento', 'Em Execução', 'Paralisado');";
            return _context.ReadQuery(query).Tables[0];
        }
    }
}