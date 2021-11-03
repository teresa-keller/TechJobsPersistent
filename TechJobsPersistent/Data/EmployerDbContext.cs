using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.Data
{
    public class EmployerDbContext : DbContext
    {
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<JobSkill> JobSkills { get; set; }
        public EmployerDbContext(DbContextOptions<EmployerDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employer>()
                .HasKey(e => new { e.Id });
        }
    }
}
