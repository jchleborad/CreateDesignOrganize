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
                new Exercise { Activity = "Workout"},
                new Exercise { Activity = "Motility"},
                new Exercise { Activity = "Diet"},
                new Exercise { Activity = "Hydration"},
            };

            foreach (Exercise e in exercises)
            {
                context.Exercises.Add(e);
            }
            context.SaveChanges();

            var lifestyles = new Lifestyle[]
            {
                new Lifestyle { List = "Reading"},
                new Lifestyle { List = "Entertainment"},
                new Lifestyle { List = "Travel"},
                new Lifestyle { List = "Goals"},
            };

            foreach (Lifestyle l in lifestyles)
            {
                context.Lifestyles.Add(l);
            }
            context.SaveChanges();

            var planners = new Planner[]
            {
                new Planner { Interval = "Day"},
                new Planner { Interval = "Week"},
                new Planner { Interval = "Month"},
                new Planner { Interval = "Year"},
            };

            foreach (Planner p in planners)
            {
                context.Planners.Add(p);
            }
            context.SaveChanges();

            var templates = new Template[]
            {
                new Template { Category = "Dots"},
                new Template { Category = "Lines"},
            };

            foreach (Template t in templates)
            {
                context.Templates.Add(t);
            }
            context.SaveChanges();
        }
    }
}


