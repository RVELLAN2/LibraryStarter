using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Domain
{
    public enum ReserveationStatus { Pending, Accepted, Rejected }
    public class Reservation
    {
        public int Id { get; set; }
        public string For { get; set; }
        public string Items { get; set; }
        public DateTime? AvailableOn { get; set; }
        public ReserveationStatus Status { get; set; }
    }
}
