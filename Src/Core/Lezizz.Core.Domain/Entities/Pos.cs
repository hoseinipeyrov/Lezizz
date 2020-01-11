﻿using Lezizz.Core.Domain.Common;

namespace Lezizz.Core.Domain.Entities
{
    public class Pos : AuditableEntity
    {
        #region Properties
        public int PosId { get; set; }
        public string PersianName { get; set; }
        public string EnglishName { get; set; }
        public int TablesCount { get; set; }
        public int SeatsCount { get; set; }
        public int ServiceChargePercent { get; set; }
        public int TaxChangePercent { get; set; }
        public int VatChangePercent { get; set; }
        public long TicketNumber { get; set; }
        public bool TicketNoDailyReset { get; set; }
        public InvoiceType InvoiceType { get; set; }

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
