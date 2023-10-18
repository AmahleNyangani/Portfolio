using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Models;

namespace Portfolio.Repositories
{
    
   
    public class ProfileRepository : IProfileRepository
    {

        IProfessionRepository professonRepository = new ProfessionRepository();
        ISkillRepository skillRepository = new SkillRepository();
        IContactRepository contactRepository= new ContactRepository();
        public Profile GetProfile()
        {
            var ListOfProfessions = professonRepository.GetAllProfessions();
            var ListOfContacts = contactRepository.GetAllContacts();
            var ListOfSkills = skillRepository.GetAllSkills();
            var aboutDescription =
                "Junior full stack developer with a demonstrated history of working in the computer software industry. Skilled in HTML Scripting, Java, C#, Visual Studio, and Databases. With a Advanced Diploma in ICT focused in Applications Development from WSU - Walter Sisulu University." +
                "I am a resourceful individual with a very high work ethic committed to making valuable contributions in problem solving and achievement of team goals. I am a life long learner with strong decision making skills. I also demonstrate excellent interpersonal, phone and digital communication skills.";
            var skillDescription =
                "I am very confident in my ability to deliver with these technologies and can also pick up new technologies pretty fast";
            var profile = new Profile("Nyangani", "Amahle", aboutDescription, skillDescription, ListOfSkills, ListOfProfessions, ListOfContacts);
            return profile;
        }


    }
}
