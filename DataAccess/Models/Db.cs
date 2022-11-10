
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.GeometriesGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Db : DbContext
    {
        public DbSet<Positions> Position { get; set; }
        public DbSet<Roles> Role { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Shifts> Shift { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<VacationRequest> VacationRequests { get; set; }
    }
}
