using SiteDiscover.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteDiscover.Domain.Entities
{
    public class NetworkArchitectureUploadedFile:BaseEntity<Guid>
    {
        public Guid NetworkArchitectureId { get; set; }
        public NetworkArchitecture NetworkArchitecture{ get; set; }
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
        public override DateTime CreatedDate { get => base.CreatedDate; set => base.CreatedDate = value; }
    }
}
