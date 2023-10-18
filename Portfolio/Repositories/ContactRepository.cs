using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Models;

namespace Portfolio.Repositories
{
    public class ContactRepository : IContactRepository
    {
        public List<Contact> GetAllContacts()
        {
          var contactList =  new List<Contact>()
            {

                new Contact(1, "Email", "amahlenyangani@gmail.com"),
                new Contact(2, "Phonenumber", "+27788384128"),
                new Contact(3, "Git", "https://github.com/AmahleNyangani"),
                new Contact(4, "LinkedIn", "https://www.linkedin.com/in/amahle-nyangani-8b4240206/"),

            };

          return contactList;
        }
    }
}
