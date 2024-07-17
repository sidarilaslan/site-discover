using Microsoft.EntityFrameworkCore;
using SiteDiscover.Application.Interfaces;
using SiteDiscover.Domain.Entities;

namespace SiteDiscover.Persistence.Contexts.EntityFramework
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Site> Sites { get; set; }
        public DbSet<ServerRoom> ServerRooms { get; set; }
        public DbSet<MeetingRoom> MeetingRooms { get; set; }
        public DbSet<ITContact> ITContacts { get; set; }
        public DbSet<GeneralInformation> GeneralInformations { get; set; }
        public DbSet<DigitalSignage> DigitalSignages { get; set; }
        public DbSet<NetworkArchitecture> NetworkArchitectures { get; set; }
        public DbSet<UploadedFile> UploadedFiles { get; set; }
        public DbSet<ITContactUploadedFile> ITContactUploadedFiles { get; set; }
    }
}
