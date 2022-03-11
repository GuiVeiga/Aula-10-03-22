namespace POO.App.API
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Pessoa()
        {
            Random random = new Random();
            Id = random.Next(1, 1000);
        }

        public Pessoa(string nome)
        {
            Random random = new Random();
            Id = random.Next(1, 1000);
            Nome = $"{nome} Todos os nomes terminam com H";
        }

        public virtual void PagarImposto(string tipoImposto)
        {
            Console.WriteLine($"O imposto informado é: {tipoImposto}");
        }
    }
}
