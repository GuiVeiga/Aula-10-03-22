using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aula10_03_22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        [HttpGet]
        public List<Empresa> Get()
        {
            var listaEmpresa = Mock.Empresa;

            return listaEmpresa;
        }

        [HttpPatch]
        public Empresa Patch(string cnpj)
        {
            var listaEmpresa = Mock.Empresa;
            var item = listaEmpresa.Find(find => find.CNPJ == cnpj);
            // Trocar find por for

            item.AplicaDivida();

            return item;
        }

        [HttpGet("Endividados")]
        public List<Empresa> GetEndividadas()
        {
            var listaEmpresa = Mock.Empresa;
            var listaEndividadas = listaEmpresa.Where(where => where.PossuiDividas == true).ToList();

            return listaEndividadas;
        }
    }
}
