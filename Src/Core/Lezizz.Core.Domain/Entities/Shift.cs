using System;

namespace Lezizz.Core.Domain.Entities
{
    public class Shift
    {
        public int ShiftId { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public string Title { get; set; }
    }
}
