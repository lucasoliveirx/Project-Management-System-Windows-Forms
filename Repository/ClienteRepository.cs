using ControleDeProjetos.Model;
using ControleProjetos.Data;
using System.Data;

namespace ControleProjetos.Repository
{
    public class ClienteRepository
    {
        DataContext _context;
        public ClienteRepository()
        {
            _context = new DataContext();
        }


        // Registrar Cliente
        public void InsertClienteRepository(Cliente cliente)
        {
            string query = $"INSERT INTO Clientes (Nome, Empresa, Cnpj, Status) VALUES ('{cliente.Nome}', '{cliente.Empresa}', '{cliente.Cpnj}', 0)";
            _context.ExecuteQuery(query);
        }

        // Visualizar Cliente (Id, Empresa)
        public DataTable VisualizarEmpresasRepository()
        {
            string query = "SELECT Id, Empresa, Status FROM Clientes ORDER BY Nome";

            DataSet dataset = _context.ReadQuery(query);
            DataTable clienteTable = dataset.Tables[0];

            return clienteTable;
        }

        // Listar Todos Clientes (filtros: Ativo : Inativo)
        public DataTable VisualizarClientesRepository(string filtro)
        {
            string query = $"SELECT Id, Empresa, Nome, CNPJ, CASE WHEN Status = 1 THEN 'Ativo' ELSE 'Inativo' END AS Status FROM Clientes {filtro}";

            DataSet dataset = _context.ReadQuery(query);
            DataTable clienteTable = dataset.Tables[0];

            return clienteTable;
        }

        // Ativar Cliente 
        public void AtivarClienteRepository(Cliente cliente)
        {
            string query = $"UPDATE Clientes SET Status = 1 WHERE Id = {cliente.Id}";
            _context.ExecuteQuery(query);
        }

        // Desativar Cliente 
        public void DesativarClienteRepository(Cliente cliente)
        {
            string query = $"UPDATE Clientes SET Status = 0 WHERE Id = {cliente.Id}";
            _context.ExecuteQuery(query);
        }
    }
}
