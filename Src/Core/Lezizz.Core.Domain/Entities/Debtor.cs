namespace Lezizz.Core.Domain.Entities
{
    public class Debtor
    {
        public int DebtorId { get; set; }
        public string Title { get; set; }
        public float Credit { get; set; }
        public float Debit { get; set; }
        public float DebitControlAmount { get; set; }
        public bool IsBlackList { get; set; }
        public bool IsVip { get; set; }
    }
}
