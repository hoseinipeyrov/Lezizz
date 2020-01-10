using System;

namespace Lezizz.Core.Domain.Entities
{
    public class TicketItem
    {
        public int TicketItemId { get; set; }
        public long TicketItemNumber { get; set; }
        public DateTime InDate { get; set; }
        public int PosId { get; set; }
        public int ItemId { get; set; }
        public int Some { get; set; }
        public float Price { get; set; }
        public float Service { get; set; }
        public float Discount { get; set; }
        public float Tax { get; set; }
        public float Vat { get; set; }
    }
}
