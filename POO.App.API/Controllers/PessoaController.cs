using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POO.App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        public List<Pessoa> Get()
        {
            var listaPessoa = new List<Pessoa>();

            var pf1 = new PessoaFisica("Nome1");
            var pf2 = new PessoaFisica("Nome2");
            var pj = new PessoaFisica("NomePJ");

            listaPessoa.Add(pf1);
            listaPessoa.Add(pf2);
            listaPessoa.Add(pj);

            return listaPessoa;
        }
    }
}
