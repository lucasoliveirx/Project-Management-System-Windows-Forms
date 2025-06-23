using System;

namespace ControleDeProjetos.Model
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Cliente Cliente { get; set; }
        public Gerente GerenteResponsavel { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public int HorasEstimadasConsultor { get; set; }
        public string Status { get; set; }

        public Projeto(int id, string nome, int clienteId, int gerenteId, DateTime? dataInicio, DateTime? dataFim, int horasEstimadasConsultor, string status)
        {
            Id = id;
            Nome = nome;
            Cliente = new Cliente(clienteId, null, null, null, null);
            GerenteResponsavel = new Gerente(gerenteId, null, null, null);
            DataInicio = dataInicio;
            DataFim = dataFim;
            HorasEstimadasConsultor = horasEstimadasConsultor;
            Status = status;
        }
    }
}
//