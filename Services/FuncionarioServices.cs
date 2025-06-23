using ControleDeProjetos.Model;
using ControleProjetos.Repository;
using System.Data;

namespace ControleProjetos.Services
{
    public class FuncionarioServices
    {
        FuncionarioRepository _repository;
        public FuncionarioServices()
        {
            _repository = new FuncionarioRepository();
        }


        public DataTable ListarFuncionarios(string cargo)
        {
            return _repository.ListarFuncionarios(cargo);
        }

        public void AtivarFuncionario(int funcionarioId)
        {
            _repository.AtivarFuncionario(funcionarioId);
        }

        public void InativarFuncionario(int funcionarioId)
        {
            _repository.InativarFuncionario(funcionarioId);
        }


        //----------------------------------------------- CONSULTORES --------------------------------------------

        // Verificação Login Consultor + Get ID Consultor 
        public Consultor GetConsultorById(Consultor consultor)
        {
            return _repository.GetConsultorByIdRepository(consultor);
        }

        // Registrar Consultor
        public void InserirConsultor(Consultor consultor)
        {
            _repository.InserirConsultorRepository(consultor);
        }

        // Listar Consultores
        public DataTable ListarConsultores()
        {
            return _repository.ListarConsultoresRepository();
        }

        public bool VerificarStatusConsultor(Consultor consultor)
        {
            DataTable dataTable = _repository.VerificarStatusConsultorRepository(consultor);

            int row = dataTable.Rows.Count;
            if (row > 0)
            {
                return true; // status consultor: ativo
            }
            else
            {
                return false; // status consultor: inativo
            }
        }


        //----------------------------------------------- GERENTES --------------------------------------------
        // Verificação Login Gerente + Get ID, Nome Gerente
        public Gerente GetGerenteById(Gerente gerente)
        {
            return _repository.GetGerenteByIdRepository(gerente);
        }

        // Registrar Gerente
        public void InserirGerente(Gerente gerente)
        {
            _repository.InserirGerenteRepository(gerente);
        }
    }
}
