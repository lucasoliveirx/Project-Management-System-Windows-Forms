namespace ControleDeProjetos.Model
{
    public class Consultor : Funcionario
    {
        public string Especialidade { get; set; }

        public Consultor(int id, string nome, string especialidade, string username, string password) : base(id, nome, "Consultor", 40, true, username, password)
        {
            Especialidade = especialidade;
        }
    }
}
