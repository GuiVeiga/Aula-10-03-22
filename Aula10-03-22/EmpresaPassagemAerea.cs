namespace Aula10_03_22
{
    public class EmpresaPassagemAerea: Empresa
    {
        public List<string> Certificacoes { get; set; }
        public List<string> CidadesDeAtuacao { get; set; }
        public string TipoDeClasse { get; set; }

        public EmpresaPassagemAerea(string nome, string cnpj): base(nome, cnpj)
        {
            
        }
    }
}
