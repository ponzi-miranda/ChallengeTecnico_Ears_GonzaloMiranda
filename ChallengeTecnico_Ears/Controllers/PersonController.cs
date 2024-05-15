using ChallengeTecnico_Ears.IService;
using ChallengeTecnico_Ears.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ChallengeTecnico_Ears.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
       

        private readonly ILogger<PersonController> _logger;

        /* Se requiere que se haga uso del servicio ya creado previamente */ 

        /* Sera valorada la persepcion y solucion de posibles escenarios de error */
        public PersonController( ILogger<PersonController> logger)
        {
            _logger = logger;
           
        }

        [HttpGet(Name = "GetPersons")]
        public List<PersonModel> Get()
        {
          
        }
    }
}
