namespace Lezizz.Core.Domain.Entities
{
    public class PosTable
    {
        public int PosTableId { get; set; }
        public int PosId { get; set; }
        public string TableNumber { get; set; }
        public int SeatsCount { get; set; }
        public bool Connectable { get; set; }
    }
}
