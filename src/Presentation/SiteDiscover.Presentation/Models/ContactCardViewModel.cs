using SiteDiscover.Application.Features.ITContacts.Queries.GetAll;

namespace SiteDiscover.Presentation.Models
{
    public class ContactCardViewModel
    {
        public string Header { get; set; }
        public IEnumerable<ITContactGetAllDto> Contacts { get; set; }
    }
}
