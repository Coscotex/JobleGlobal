using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JobleGlobal.Models
{
    public partial class JobleDBContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrganisationPlan> OrganisationPlan { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }

        public JobleDBContext(DbContextOptions<JobleDBContext> options)
                : base(options)
        {
        }
    }
}
