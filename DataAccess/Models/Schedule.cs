using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    internal class Schedule
    {
        public int SchedileId { get; set; }
        public int ShiftId { get; set; }
        public int PositionId { get; set; }
        public int UserId { get; set; }
        public DateTime Data { get; set; }
    }
}
