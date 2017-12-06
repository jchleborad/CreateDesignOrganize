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
        public DbSet<Planner> Planners { get; set; } //tells the program create a table called planners based on the planner model
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}


//create models
//add models to applicationDbContext.cs
//add-migration 'name'
//update-database
//??Seed data (last)??

    //do a project build prior to migration to ensure project builds
    //watch for something like "aspnet users already exist as a table - re-build database", so delete all files in Migration folder (NOT ApplicationDbContext
    //in SQL Obj Exp right-click on name of DB and delete - check box "close existing connecttion" should be checked prior to delete
    //then add-migration and update-database