using Microsoft.EntityFrameworkCore;
using PMI_Site.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Interfaces
{
    public interface IPMISiteContext
    {
        DbSet<Site> Sites { get; set; }
        DbSet<ServerRoom> ServerRooms { get; set; }
        DbSet<MeetingRoom> MeetingRooms { get; set; }
        DbSet<ITContact> ITContacts { get; set; }
        DbSet<GeneralInformation> GeneralInformations { get; set; }
        DbSet<DigitalSignage> DigitalSignages { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
