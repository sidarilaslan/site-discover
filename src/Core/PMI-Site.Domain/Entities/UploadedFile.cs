using PMI_Site.Domain.Common;
using PMI_Site.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Domain.Entities
{
    public class UploadedFile : BaseEntity<Guid>
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public FileType? FileType { get; set; } = null;
        public string Extension { get; set; }
        public string? Directory { get; set; } = null;
        [NotMapped]
        public override string? ModifiedUserId { get => base.ModifiedUserId; set => base.ModifiedUserId = value; }
        [NotMapped]
        public override DateTime? ModifiedDate { get => base.ModifiedDate; set => base.ModifiedDate = value; }
        [NotMapped]
        public override DateTime CreatedDate { get => base.CreatedDate; set => base.CreatedDate = value; }
        public ITContactUploadedFile ITContactUploadedFile { get; set; }
    }
}
