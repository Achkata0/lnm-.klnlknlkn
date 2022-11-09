using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    internal class VacationRequest
    {
        public int VacationRequestId { get; set; }
        public int UserId { get; set; }
        public DateTime DayRequest { get; set; }
        public int Accepted { get; set; }
    }
}
