using ChallengeTecnico_Ears.Context;
using ChallengeTecnico_Ears.IService;
using ChallengeTecnico_Ears.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeTecnico_Ears.Services
{
    public class PersonService : IPersonService
    {

        private readonly ContextChallenge _context;
        public PersonService(ContextChallenge dbContext)
        {
            _context = dbContext;
        }


        public List<PersonModel> GetPersonList()
        {

            List<PersonModel> _Person = new List<PersonModel>();

            /* Aquí será requerido implementar la lógica para llamar y recuperar los datos de la base 
               Se requiere recuperar los datos de las personas activas con sus respectivas oficinas  
               y luego filtrar a las personas con legajo mayor a 1003 */

            /* Será valorada la percepción y solución de posibles escenarios de error */

            return _Person;
        }



    }
}
