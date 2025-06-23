namespace ControleDeProjetos.Model
{
    public abstract class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; }
        public int CargaHorariaSemanal { get; set; } // Padrão = 40h
        public bool Status { get; set; }
        public string Username { get; }
        public string Password { get; }

        public Funcionario(int id, string nome, string cargo, int cargaHorariaSemanal, bool status, string username, string password)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            CargaHorariaSemanal = cargaHorariaSemanal;
            Status = status;
            Username = username;
            Password = password;
        }
    }
}
