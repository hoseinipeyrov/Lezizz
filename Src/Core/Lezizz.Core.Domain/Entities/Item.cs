namespace Lezizz.Core.Domain.Entities
{
    public class Item
    {
        public int ItemId { get; set; }
        public string PName { get; set; }
        public string EName { get; set; }
        public float Price { get; set; }
        public bool HasServiceEffect { get; set; }
        public bool HasDiscountEffect { get; set; }
        public string ImagePath { get; set; }
        public string BriefRpc { get; set; }
        public string Description { get; set; }
        public bool DailySaleCheck { get; set; }
    }
}
