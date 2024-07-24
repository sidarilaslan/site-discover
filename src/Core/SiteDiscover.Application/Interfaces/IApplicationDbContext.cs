using Microsoft.EntityFrameworkCore;
using SiteDiscover.Domain.Entities;

namespace SiteDiscover.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Site> Sites { get; set; }
        DbSet<ServerRoom> ServerRooms { get; set; }
        DbSet<MeetingRoom> MeetingRooms { get; set; }
        DbSet<ITContact> ITContacts { get; set; }
        DbSet<GeneralInformation> GeneralInformations { get; set; }
        DbSet<DigitalSignage> DigitalSignages { get; set; }
        DbSet<NetworkArchitecture> NetworkArchitectures { get; set; }
        DbSet<UploadedFile> UploadedFiles { get; set; }
        DbSet<ITContactUploadedFile> ITContactUploadedFiles { get; set; }
        DbSet<NetworkArchitectureUploadedFile> NetworkArchitectureUploadedFiles { get; set; }
        DbSet<ServerRoomUploadedFile> ServerRoomUploadedFiles { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
