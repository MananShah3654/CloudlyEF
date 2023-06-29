using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CloudlyEF.Models
{
    public class Customers
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedNewsLetter { get; set; }
        public MembershipType MembershipType {get; set;}
        public byte MembershipTypeId { get; set; }

}
}