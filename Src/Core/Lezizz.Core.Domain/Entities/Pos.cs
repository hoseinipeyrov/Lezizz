using Lezizz.Core.Domain.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Lezizz.Core.Domain.Entities
{
    public class Pos : AuditableEntity
    {
        #region Properties
        public int PosId { get; set; }
        public string PersianName { get; set; }
        [DisplayName("Name")]
        public string EnglishName { get; set; }

        [DisplayName("Tables Count")]
        public int TablesCount { get; set; }
        [DisplayName("Seats Count")]
        public int SeatsCount { get; set; }
        public int ServiceChargePercent { get; set; }
        public int TaxChangePercent { get; set; }
        public int VatChangePercent { get; set; }
        [DisplayName("Ticket Number")]
        public long TicketNumber { get; set; }
        [DisplayName("Ticket No Daily Reset")]
        public bool TicketNoDailyReset { get; set; }
        public InvoiceType InvoiceType { get; set; } = InvoiceType.A5;

        #endregion

        #region Navigations

        #endregion


    }

    public enum InvoiceType
    {
         A5 = 1,
        PosPrinter = 2
    }
}
