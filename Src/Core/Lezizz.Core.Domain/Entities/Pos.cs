using Lezizz.Core.Domain.Common;
using System.Collections.Generic;
using System.Text;

namespace Lezizz.Core.Domain.Entities
{
    public class Pos : AuditableEntity
    {
        #region Properties
        public int PosId { get; set; }
        public string PName { get; set; }
        public string EName { get; set; }
        public int Tables { get; set; }
        public int Seats { get; set; }
        public int ServiceChargePercent { get; set; }
        public int TaxChangePercent { get; set; }
        public int VatChangePercent { get; set; }
        public long TicketNumber { get; set; }
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
