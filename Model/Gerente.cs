namespace ControleDeProjetos.Model
{
    public class Gerente : Funcionario
    {
        public Gerente(int id, string nome, string username, string password) : base(id, nome, "Gerente", 40, true, username, password) { }
    }
}