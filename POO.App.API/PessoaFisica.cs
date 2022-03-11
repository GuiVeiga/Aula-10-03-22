namespace POO.App.API
{
    public class PessoaFisica: Pessoa
    {
        public string CPF { get; set; }

        public PessoaFisica(string nome): base(nome) { }

        public override void PagarImposto(string tipoImposto = "IRPF")
        {
            base.PagarImposto("IRPF");
        }
    }
}
