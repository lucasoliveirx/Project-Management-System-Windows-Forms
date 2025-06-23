using ControleDeProjetos.Model;
using ControleProjetos.Data;
using System;
using System.Data;

namespace ControleProjetos.Repository
{
    public class FuncionarioRepository
    {
        DataContext _context;
        public FuncionarioRepository()
        {
            _context = new DataContext();
        }

        // Listar Funcionários (Filtro: Cargo)
        public DataTable ListarFuncionarios(string cargo)
        {
            string query = $"SELECT Id, Nome, Cargo, Especialidade, CargaHorariaSemanal, CASE WHEN Status = 1 THEN 'Ativo' ELSE 'Inativo' END AS Status, Username, UserPassword FROM Funcionarios WHERE Cargo = '{cargo}';";
            return _context.ReadQuery(query).Tables[0];
        }

        // Ativar Funcionário
        public void AtivarFuncionario(int funcionarioId)
        {
            string query = $"UPDATE Funcionarios SET Status = 1 WHERE Id = {funcionarioId}";
            _context.ExecuteQuery(query);
        }

        // Inativar Funcionário
        public void InativarFuncionario(int funcionarioId)
        {
            string query = $"UPDATE Funcionarios SET Status = 0 WHERE Id = {funcionarioId}";
            _context.ExecuteQuery(query);
        }

        //----------------------------------------------- CONSULTORES --------------------------------------------
        // Inserir Consultor
        public void InserirConsultorRepository(Consultor consultor)
        {
            string query = $"INSERT INTO Funcionarios (Nome, Cargo, CargaHorariaSemanal, Especialidade, Username, UserPassword) VALUES ('{consultor.Nome}', '{consultor.Cargo}', '{consultor.CargaHorariaSemanal}', '{consultor.Especialidade}', '{consultor.Username}', '{consultor.Password}')";
            _context.ExecuteQuery(query);
        }

        // Listar Todos Consultores
        public DataTable ListarConsultoresRepository()
        {
            string query = $"SELECT Id, Nome FROM Funcionarios WHERE Cargo = 'Consultor' ORDER BY NOME";

            DataSet dataSet = _context.ReadQuery(query);

            DataTable consultoresTable = dataSet.Tables[0];

            return consultoresTable;
        }

        // Verificar se o Consultor Está Ativo
        public DataTable VerificarStatusConsultorRepository(Consultor consultor)
        {
            string query = $"SELECT Nome FROM Funcionarios WHERE Id = {consultor.Id} AND Status = 1";
            return _context.ReadQuery(query).Tables[0];
        }


        // Verificação de Login do Consultor buscando o (Id, Nome) para assim abrir novas abas com o Consultor já setado
        public Consultor GetConsultorByIdRepository(Consultor consultor)
        {
            string query = $"SELECT Id, Nome, Cargo FROM Funcionarios WHERE Username = '{consultor.Username}' AND UserPassword = '{consultor.Password}' AND Cargo = 'Consultor' AND Status = 1";

            DataSet dataSet = _context.ReadQuery(query);
            DataTable consultorTable = dataSet.Tables[0];

            foreach (DataRow row in consultorTable.Rows)
            {
                int id = Convert.ToInt32(row["Id"]);
                string nome = row["Nome"].ToString();

                consultor = new Consultor(id, nome, null, null, null);

                return consultor;
            }
            return null;
        }

        //----------------------------------------------- GERENTES --------------------------------------------

        // Verificação de Login do Gerente buscando somente o Id e o Nome, para assim abrir novas abas com o Gerente já logado
        public Gerente GetGerenteByIdRepository(Gerente gerente)
        {
            string query = $"SELECT Id, Nome, Cargo FROM Funcionarios WHERE Username = '{gerente.Username}' AND UserPassword = '{gerente.Password}' AND Cargo = 'Gerente' AND Status = 1";

            DataSet dataSet = _context.ReadQuery(query);
            

            DataTable loginTable = dataSet.Tables[0];

            foreach (DataRow row in loginTable.Rows)
            {
                int id = Convert.ToInt32(row["Id"]);
                string nome = row["Nome"].ToString();

                gerente = new Gerente(id, nome, null, null);

                return gerente;
            }
            return null;
        }

        public void InserirGerenteRepository(Gerente gerente)
        {
            string query = $"INSERT INTO Funcionarios (Nome, Cargo, CargaHorariaSemanal, Username, UserPassword) VALUES ('{gerente.Nome}', '{gerente.Cargo}', '{gerente.CargaHorariaSemanal}', '{gerente.Username}', '{gerente.Password}')";
            _context.ExecuteQuery(query);
        }
    }
}