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

            try
            {
                _Person = _context.T_Person.Include(p => p.Offices).Where(p => p.Active && p.EmployeeFile > 1003).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar la lista de personas.", ex);
            }

            return _Person;
        }
    }
}
