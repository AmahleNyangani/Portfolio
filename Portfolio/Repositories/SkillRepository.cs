using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Models;

namespace Portfolio.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        public List<Skill> GetAllSkills()
        {
           var skillLsList = new List<Skill>()
            {
                new Skill(1, "HTML", "90"),
                new Skill(2, "CSS", "70"),
                new Skill(3, "JavaScript", "80"),
                new Skill(4, "SQL", "70"),
                new Skill(5, "ASP.NET MVC", "80"),
                new Skill(6, ".NET CORE", "80"),
                new Skill(7, "Telerik Report", "80"),
                new Skill(8, "Microsoft SQL Sever Management Studio", "90"),

            };
           return skillLsList;
        }
    }
}
