using System;
using System.Collections.Generic;
using System.Text;

namespace My.Web.Entities
{
    public class EntityBase : IEntityBase
    {
        public Guid KeyId { get; set; } = new Guid();
        public bool IsLocked { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public long? CreatedBy { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
