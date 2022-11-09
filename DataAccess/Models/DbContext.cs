using DocumentFormat.OpenXml.Drawing;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.GeometriesGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class DbContext : DbContext
    {
        public DbSet<Positions> Positions { get; set; }
        public DbSet<Roless> Roles { get; set; }
        public DbSet<Schedules> Schedules { get; set; }
        public DbSet<Shifts> Shifts { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<VacationRequests> VacationRequests { get; set; }
    }
}
