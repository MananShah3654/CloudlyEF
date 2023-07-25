using CloudlyEF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CloudlyEF.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedNewsLetter { get; set; }

         public byte MembershipTypeId { get; set; }

        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public MembershipTypeDto MembershipType { get; set; }
    }
}