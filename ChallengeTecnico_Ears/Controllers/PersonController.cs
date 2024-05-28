using ChallengeTecnico_Ears.IService;
using ChallengeTecnico_Ears.Models;
using ChallengeTecnico_Ears.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ChallengeTecnico_Ears.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {


        private readonly IPersonService _personService;
        private readonly ILogger<PersonController> _logger;



        public PersonController(ILogger<PersonController> logger, IPersonService iPersonService)
        {
            _logger = logger;
            this._personService = iPersonService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var personas = _personService.GetPersonList();
                if (personas == null || !personas.Any())
                {
                    return NotFound("No se encontraron personas activas con legajo mayor a 1003.");
                }

                return Ok(personas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar la lista de personas.");
                return StatusCode(500, "Ocurrió un error al procesar la solicitud.");
            }
        }
    }
}
