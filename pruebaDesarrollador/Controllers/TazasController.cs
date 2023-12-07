using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pruebaDesarrollador.Data;
using pruebaDesarrollador.Entity;
using pruebaDesarrollador.Entity.DTO;

namespace pruebaDesarrollador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TazasController : ControllerBase
    {
        private readonly tazaDBContext context;

        public TazasController(tazaDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult> getTaza(int monto, int plazo)
        {
            var cotizar = new Cotizador();
            cotizar.valorRendimiento = 0;
            cotizar.valorRendimiento = monto * 0.5f * plazo;
            cotizar.MontoRecibir = 0;
            cotizar.MontoRecibir = monto + cotizar.valorRendimiento;
            await context.SaveChangesAsync();
            return Ok(cotizar);
        }
    }
}
