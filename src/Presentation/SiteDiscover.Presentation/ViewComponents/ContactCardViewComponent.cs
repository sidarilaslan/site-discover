using Microsoft.AspNetCore.Mvc;
using SiteDiscover.Application.Features.ITContacts.Queries.GetAll;
using SiteDiscover.Presentation.Models;
using System.Collections.Generic;
using System.Globalization;

namespace SiteDiscover.Presentation.ViewComponents
{
    public class ContactCardViewComponent : BaseViewComponent
    {
        public IViewComponentResult Invoke(string header, IEnumerable<ITContactGetAllDto> contacts)
        {
            ContactCardViewModel? model = new ContactCardViewModel
            {
                Header = header,
                Contacts = contacts
            };

            return View(model);
        }
    }
}