﻿using SiteDiscover.Domain.Entities;
using SiteDiscover.Domain.Enums;

namespace SiteDiscover.Application.Features.ITContacts.Queries.GetAll
{
    public class ITContactGetAllDto
    {
        public ITContactCategory ITContactCategory { get; set; }
        public string Username { get; set; }
        public string UserJobTitle { get; set; }

        public static ITContactGetAllDto FromITContact(ITContact ITContact)
            => new()
            {
                Username = ITContact.Username,
                UserJobTitle = ITContact.UserJobTitle,
                ITContactCategory = ITContact.ITContactCategory
            };
    }
}