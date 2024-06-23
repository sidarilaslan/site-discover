using PMI_Site.Domain.Entities;
using PMI_Site.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.ITContacts.Queries.GetAll
{
    public class ITContactGetAllResponse
    {
        public ITContactCategory ITContactCategory { get; set; }
        public string Username { get; set; }
        public string UserJobTitle { get; set; }

        public static ITContactGetAllResponse FromITContact(ITContact ITContact)
            => new()
            {
                Username = ITContact.Username,
                UserJobTitle = ITContact.UserJobTitle,
                ITContactCategory = ITContact.ITContactCategory
            };
    }
}
