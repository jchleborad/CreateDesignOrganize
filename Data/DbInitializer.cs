using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CreateDesignOrganize.Models;

namespace CreateDesignOrganize.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Planners.Any())
            {
                return; //DB has been seeded
            }

            var exercises = new Exercise[]
            {
                new Exercise { Size = "USLetter", Style = "Fancy", Type = "Workout", Activity = "Running"},
                new Exercise { Size = "USLetter", Style = "Modern", Type = "Workout", Activity = "Running"},

            };

            foreach (Exercise e in exercises)
            {
                context.Exercises.Add(e);
            }
            context.SaveChanges();

            var lifestyles = new Lifestyle[]
            {
                new Lifestyle { Size = "USLetter", Style = "Fancy", Type = "ReadingList",},
                new Lifestyle { Size = "USLetter", Style = "Modern", Type = "ReReadingListad"},
 
            };

            foreach (Lifestyle l in lifestyles)
            {
                context.Lifestyles.Add(l);
            }
            context.SaveChanges();

            var planners = new Planner[]
            {
                new Planner { Size = "USLetter", Style = "Fancy", Type = "SinglePage", Period = "Day"},
                new Planner { Size = "USLetter", Style = "Modern", Type = "SinglePage", Period = "Day"},
  
            };

            foreach (Planner p in planners)
            {
                context.Planners.Add(p);
            }
            context.SaveChanges();

            var templates = new Template[]
            {
                new Template { Size = "USLetter", Style = "Blank", Type = "Dots"},
                new Template { Size = "USLetter", Style = "Blank", Type = "Lines"},
            };

            foreach (Template t in templates)
            {
                context.Templates.Add(t);
            }
            context.SaveChanges();
        }
    }
}


