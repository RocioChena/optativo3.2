
using Microsoft.AspNetCore.Mvc;
using Servicio.Conversiones;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FechaController : ControllerBase
    {
        private readonly FechaService _fechaService;

        // Constructor que inicializa el servicio FechaService.
        public FechaController()
        {
            _fechaService = new FechaService();
        }

        /// <summary>
        /// Obtiene la fecha actual en formato corto "dd/MM/yyyy".
        /// </summary>
        /// <returns>Fecha en formato corto.</returns>
        [HttpGet("corto")]
        public IActionResult ObtenerFechaFormatoCorto()
        {
            var fechaCorta = _fechaService.ObtenerFechaFormatoCorto();
            return Ok(new { Formato = "Corto", Fecha = fechaCorta });
        }

        /// <summary>
        /// Obtiene la fecha actual en formato largo "dddd, dd MMMM yyyy".
        /// </summary>
        /// <returns>Fecha en formato largo.</returns>
        [HttpGet("largo")]
        public IActionResult ObtenerFechaFormatoLargo()
        {
            var fechaLarga = _fechaService.ObtenerFechaFormatoLargo();
            return Ok(new { Formato = "Largo", Fecha = fechaLarga });
        }

        /// <summary>
        /// Obtiene la fecha actual en formato ISO "yyyy-MM-ddTHH:mm:ss".
        /// </summary>
        /// <returns>Fecha en formato ISO.</returns>
        [HttpGet("iso")]
        public IActionResult ObtenerFechaFormatoISO()
        {
            var fechaISO = _fechaService.ObtenerFechaFormatoISO();
            return Ok(new { Formato = "ISO", Fecha = fechaISO });
        }
    }
}
