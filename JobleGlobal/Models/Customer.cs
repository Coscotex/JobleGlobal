using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobleGlobal.Models
{
    public partial class Customer
    {
        public Customer()
        {
            OrganisationPlan = new HashSet<OrganisationPlan>();
        }

        public int Id { get; set; }
        [Required]
        [Display(Name = "Organisation Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Contact Number1")]
        [StringLength(15, MinimumLength = 5)]
        public string ContactNumber1 { get; set; }
        [Display(Name = "Contact Number2")]
        [StringLength(15, MinimumLength = 5)]
        public string ContactNumber2 { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email1 { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email2 { get; set; }
        public string PrimaryContactPersonGuid { get; set; }

        public ICollection<OrganisationPlan> OrganisationPlan { get; set; }
    }
}
