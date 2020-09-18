using System;
using System.Collections.Generic;
using System.Text;

namespace OT.DAL.Entities
{
   public class BaseEntity
    {
        public int ID { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
