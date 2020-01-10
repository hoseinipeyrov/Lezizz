using System;

namespace Lezizz.Core.Domain.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public long TicketNumber { get; set; }
        public DateTime InDate { get; set; }
        public int PosId { get; set; }
        public int DebtorId { get; set; }
        public string GuestFullName { get; set; }
        public byte ServingType { get; set; }
        public float Price { get; set; }
        public float Service { get; set; }
        public float DiscountPercent { get; set; }
        public float Discount { get; set; }
        public float Tax { get; set; }
        public float Vat { get; set; }
        public float SumPrice { get; set; }
        public int Operator { get; set; }
        public bool IsArchived { get; set; }
        public bool IsVoid { get; set; }
        public int PaymentType { get; set; }
        public DateTime AccountCloseDate { get; set; }
    }
}
