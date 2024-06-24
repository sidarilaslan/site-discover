using Microsoft.EntityFrameworkCore;
using PMI_Site.Application.Interfaces;
using PMI_Site.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Persistence.Contexts.EntityFramework
{
    public class PMISiteContext : DbContext, IPMISiteContext
    {
        public PMISiteContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Site> Sites { get; set; }
        public DbSet<ServerRoom> ServerRooms { get; set; }
        public DbSet<MeetingRoom> MeetingRooms { get; set; }
        public DbSet<ITContact> ITContacts { get; set; }
        public DbSet<GeneralInformation> GeneralInformations { get; set; }
        public DbSet<DigitalSignage> DigitalSignages { get; set; }
        public DbSet<NetworkArchitecture> NetworkArchitectures { get; set; }
    }
}
