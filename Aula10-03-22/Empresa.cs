namespace Aula10_03_22
{
    public class Empresa
    {
        public Empresa(string nome, string cNPJ)
        {
            Nome = nome;
            CNPJ = cNPJ;
        }

        public Empresa(string nome, string cNPJ, List<Funcionario> funcionario, bool possuiDividas)
        {
            Nome = nome;
            CNPJ = cNPJ;
            Funcionario = funcionario;
            PossuiDividas = possuiDividas;
        }

        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public List<Funcionario> Funcionario { get; set; }
        public bool PossuiDividas { get; private set; }

        public void AplicaDivida()
        {
            PossuiDividas = true;
        }
    }
}
