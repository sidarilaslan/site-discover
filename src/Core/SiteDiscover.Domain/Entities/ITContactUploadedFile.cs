using System.ComponentModel.DataAnnotations.Schema;
using SiteDiscover.Domain.Common;

namespace SiteDiscover.Domain.Entities
{
    public class ITContactUploadedFile : BaseEntity<Guid>
    {
        public Guid ITContactId { get; set; }
        public ITContact ITContact { get; set; }
        public UploadedFile UploadedFile { get; set; }
        public Guid UploadedFileId { get; set; }
        [NotMapped]
        public override string? CreatedByUserId { get => base.CreatedByUserId; set => base.CreatedByUserId = value; }
        [NotMapped]
        public override bool IsActive { get => base.IsActive; set => base.IsActive = value; }
        [NotMapped]
        public override bool IsDeleted { get => base.IsDeleted; set => base.IsDeleted = value; }
        [NotMapped]
        public override DateTime? ModifiedDate { get => base.ModifiedDate; set => base.ModifiedDate = value; }
        [NotMapped]
        public override string? ModifiedUserId { get => base.ModifiedUserId; set => base.ModifiedUserId = value; }
        [NotMapped]
        public override DateTime CreatedDate { get => base.CreatedDate ; set => base.CreatedDate = value; }



    }
}
