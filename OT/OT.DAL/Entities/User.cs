using System;
using System.Collections.Generic;
using System.Text;

namespace OT.DAL.Entities
{
   public class User:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }
        public string Department { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
    }
}
