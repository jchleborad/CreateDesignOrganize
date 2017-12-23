using CreateDesignOrganize.Data;
using CreateDesignOrganize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateDesignOrganize.Services
{
    public class PlannerService 
    {
        private ApplicationDbContext _db;
        public PlannerService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Planner> GetPlanners()
        {
            return _db.Planners.ToList();
        }
    }
}
