using ControleDeProjetos.Model;
using ControleProjetos.Repository;
using System.Data;

namespace ControleProjetos.Services
{
    public class ClienteServices
    {
        ClienteRepository _repository;
        public ClienteServices()
        {
            _repository = new ClienteRepository();
        }

        public void InsertCliente(Cliente cliente)
        {
            _repository.InsertClienteRepository(cliente);
        }

        public DataTable VisualizarEmpresas()
        {
            return _repository.VisualizarEmpresasRepository();
        }

        public DataTable VisualizarClientes(string filtro)
        {
            return _repository.VisualizarClientesRepository(filtro);
        }

        public void AtivarCliente(Cliente cliente)
        {
            _repository.AtivarClienteRepository(cliente);
        }

        public void DesativarCliente(Cliente cliente)
        {
            _repository.DesativarClienteRepository(cliente);
        }
    }
}
