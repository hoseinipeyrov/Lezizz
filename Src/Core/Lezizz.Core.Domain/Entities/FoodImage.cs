using System;
using System.Collections.Generic;
using System.Text;

namespace Lezizz.Core.Domain.Entities
{
    public class FoodImage
    {
        #region Properties
        public int FoodImageId { get; set; }
        public int FoodId { get; set; }
        public string ImagePath { get; set; }
        #endregion

        #region Navigations
        public Food Food { get; set; }
        #endregion
    }
}
