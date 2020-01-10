using Lezizz.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lezizz.Core.Domain.Entities
{
    public class FoodCategory : AuditableEntity
    {
        #region Properties
        public int FoodCategoryId { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        #endregion

        #region Navigations
        public ICollection<Food> Foods { get; set; } = new HashSet<Food>();
        #endregion

    }
}
