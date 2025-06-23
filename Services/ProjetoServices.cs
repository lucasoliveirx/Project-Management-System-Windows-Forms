using ControleDeProjetos.Model;
using ControleProjetos.Repository;
using System;
using System.Data;

namespace ControleProjetos.Services
{
    public class ProjetoServices
    {
        ProjetoRepository _repository;
        public ProjetoServices()
        {
            _repository = new ProjetoRepository();
        }


        public void CriarProjeto(Projeto projeto)
        {
            _repository.InserirProjetoRepository(projeto);
        }

        public DataTable ListarProjetos(string filtroStatus)
        {
            return _repository.ListarProjetosRepository(filtroStatus);
        }

        public bool VerificarProjetoAtivo(Projeto projeto)
        {
            DataTable dataTable = _repository.VerificarProjetoAtivoRepository(projeto);
            int projetoRow = dataTable.Rows.Count;

            if (projetoRow > 0)
            {
                return true; // Projeto Ativo
            }
            else
            {
                return false; // Projeto Inativo
            }
        }

        public void AtualizarHorasEstimadas()
        {
            _repository.AtualizarHorasEstimadasRepository();
        }

        public void EncerrarProjeto(Projeto projeto)
        {
            _repository.EncerrarProjetoRepository(projeto);
        }

        public void ZerarHorasEstimadas(Projeto projeto)
        {
            _repository.ZerarHorasEstimadasRepository(projeto);
        }

        public bool ProjetosAtivosCliente(Cliente cliente)
        {
            DataTable dataTable = _repository.ProjetosAtivosClientesRepository(cliente);
            int row = dataTable.Rows.Count;

            if (row > 0)
            {
                return true; // Cliente Possui Projetos Ativos
            }
            else
            {
                return false; // Cliente Não Possui Projetos Ativos
            }
        }

        public int GetClienteIdByProjetoId(Projeto projeto)
        {
            DataTable dataTable = _repository.GetClienteIdByProjetoIdRepository(projeto);

            foreach (DataRow row in dataTable.Rows)
            {
                int clienteId = Convert.ToInt32(row["ClienteId"]);
                return clienteId;
            }
            return 0;
        }

        public bool ProjetosAtivosGerente(int gerenteId)
        {
            DataTable dataTable = _repository.VerificarProjetosAtivosGerenteRepository(gerenteId);
            int row = dataTable.Rows.Count;

            if (row > 0)
            {
                return true; // Cliente Possui Projetos Ativos
            }
            else
            {
                return false; // Cliente Não Possui Projetos Ativos
            }
        }
    }
}

