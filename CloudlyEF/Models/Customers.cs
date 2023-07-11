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
        
        [Required(ErrorMessage ="Name is required.")]
        [StringLength(255)]
        public string Name { get; set; }
        
        public bool IsSubscribedNewsLetter { get; set; }

        [Display(Name = "Membership Type")]
        public MembershipType MembershipType {get; set;}
        
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

    }
}