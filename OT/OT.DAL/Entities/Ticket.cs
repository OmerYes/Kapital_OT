using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OT.DAL.Entities
{
  public class Ticket:BaseEntity
    {
        public string Status { get; set; }
        public string Subject { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Body { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        
  }
}
