using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Domain.Common
{
    public abstract class BaseEntity<TKey> : IEntity<TKey> 
   {
        public TKey Id { get ; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public virtual bool IsActive { get; set; } = true;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual string? CreatedByUserId { get; set; }
        public virtual string? ModifiedUserId { get; set; }
    }
}
