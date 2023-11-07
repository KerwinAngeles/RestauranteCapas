using Capa_Entidades;
using Capa_Servicios;
using Microsoft.AspNetCore.Mvc;

namespace CapaAPI.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class OrdenController : ControllerBase
    {
        OrdenService _ordenService;

        public OrdenController()
        {
            _ordenService = new OrdenService();
        }

        [HttpPost]
        [Route("Orden")]

        public IActionResult getOrden(string nombre, string apellido, string orden)
        {
            Cliente cliente = new Cliente(nombre, apellido, orden);
            _ordenService.getOrden(cliente);
            return Ok(cliente);

        }
    }
}
