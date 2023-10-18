using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Models;

namespace Portfolio.Repositories
{
    public class ProfessionRepository : IProfessionRepository
    {
        public List<Profession> GetAllProfessions()
        {
        var professionList =    new List<Profession>()
            {
                new Profession(1, "Junior Software Developer"),
                new Profession(2, "Cricket Player"),
 
            };
            return professionList;
        }
    }
}
