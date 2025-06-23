using ControleDeProjetos.Model;
using ControleProjetos.Repository;
using System;
using System.Data;

namespace ControleProjetos.Services
{
    public class AlocacoesServices
    {
        AlocacoesRepository _repository;
        public AlocacoesServices()
        {
            _repository = new AlocacoesRepository();
        }


        public bool VerificarConsultorProjeto(Projeto projeto, Consultor consultor)
        {
            bool verificarConsultor = _repository.VerificarConsultorProjetoRepository(projeto, consultor);
            return verificarConsultor;
            
        }

        public void AlocarConsultorProjeto(Projeto projeto, Consultor consultor)
        {
            _repository.AlocarConsultorProjetoRepository(projeto, consultor);
        }

        public DataSet AtualizarCargaHorariaConsultor()
        {
            DataSet dataSet = _repository.QuantidadeProjetosPorConsultorRepository();
            DataTable consultorTable = dataSet.Tables[0];

            foreach (DataRow row1 in consultorTable.Rows)
            {
                int consultorId = Convert.ToInt32(row1["ConsultorId"]);
                Consultor consultor = new Consultor(consultorId, null, null, null, null);

                int totalProjetos = Convert.ToInt32(row1["TotalProjetos"]);
                int cargaHorariaSemanal = 40 / totalProjetos;

                DataTable projetoTable = _repository.BuscarProjetosAtivosRepository(consultorId);

                foreach (DataRow row2 in projetoTable.Rows)
                {
                    int projetoId = Convert.ToInt32(row2["ProjetoId"]);
                    Projeto projeto = new Projeto(projetoId, null, 0, 0, null, null, 0, null);

                    _repository.AtualizarCargaHorariaSemanalRepository(projeto, consultor, cargaHorariaSemanal);
                }
            }
            return null;
        }

        public DataTable GerarRelatorio(string filtroConsultor, string filtroStatus)
        {
            return _repository.GerarRelatorioRepository(filtroConsultor, filtroStatus);
        }

        public bool VerificarProjetosAtivosConsultor(int funcionarioId)
        {
            DataTable dataTable = _repository.BuscarProjetosAtivosRepository(funcionarioId);
            int dataRow = dataTable.Rows.Count;

            if (dataRow > 0)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }
    }
}
