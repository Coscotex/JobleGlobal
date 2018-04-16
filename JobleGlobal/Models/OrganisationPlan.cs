using System;
using System.Collections.Generic;

namespace JobleGlobal.Models
{
    public partial class OrganisationPlan
    {
        public int Id { get; set; }
        public int OrganisationId { get; set; }
        public int PlanId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

        public Customer Organisation { get; set; }
        public Plan Plan { get; set; }
    }
}
