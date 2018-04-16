using System;
using System.Collections.Generic;

namespace JobleGlobal.Models
{
    public partial class Plan
    {
        public Plan()
        {
            OrganisationPlan = new HashSet<OrganisationPlan>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public ICollection<OrganisationPlan> OrganisationPlan { get; set; }
    }
}
