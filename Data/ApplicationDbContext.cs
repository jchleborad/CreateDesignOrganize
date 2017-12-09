using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CreateDesignOrganize.Models;

namespace CreateDesignOrganize.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //tells the program to create a table called "names"  based on the <name>.cs model
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Lifestyle> Lifestyles { get; set; }
        public DbSet<Planner> Planners { get; set; }
        public DbSet<Template> Templates { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            modelBuilder.Entity<Exercise>().ToTable("Exercise");
            modelBuilder.Entity<Lifestyle>().ToTable("Lifestyle");
            modelBuilder.Entity<Planner>().ToTable("Planner");
            modelBuilder.Entity<Template>().ToTable("Template");

        }
    }
}