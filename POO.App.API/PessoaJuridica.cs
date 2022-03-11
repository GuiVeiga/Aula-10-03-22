namespace POO.App.API
{
    public class PessoaJuridica: Pessoa
    {
        public string CNPJ { get; set; }

        PessoaJuridica(string nome): base(nome) { }

        public override void PagarImposto(string tipoImposto = "ICMS")
        {
            base.PagarImposto(tipoImposto);
        }
    }
}
