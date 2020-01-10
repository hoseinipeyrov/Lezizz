using Lezizz.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lezizz.Core.Domain.Entities
{
    public class FoodPrice : AuditableEntity
    {
        #region Properties
        public int FoodPriceId { get; set; }
        public int FoodId { get; set; }

        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        #endregion

        #region Navigations
        public Food Food { get; set; }
        #endregion


    }
}
