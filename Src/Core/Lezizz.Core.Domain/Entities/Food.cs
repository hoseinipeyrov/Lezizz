using Lezizz.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lezizz.Core.Domain.Entities
{
    public class Food : AuditableEntity
    {
        #region Properties
        public int FoodId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        #endregion

        #region Navigations
        public FoodCategory FoodCategory { get; set; }
        public ICollection<FoodImage> FoodImages { get; set; } = new HashSet<FoodImage>();
        #endregion


    }
}
