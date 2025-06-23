namespace ControleDeProjetos.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public string Cpnj { get; set; }
        public bool? Status { get; set; }

        public Cliente(int id, string nome, string empresa, string cnpj, bool? status)
        {
            Id = id;
            Nome = nome;
            Empresa = empresa;
            Cpnj = cnpj;
            Status = status;
        }
    }
}
