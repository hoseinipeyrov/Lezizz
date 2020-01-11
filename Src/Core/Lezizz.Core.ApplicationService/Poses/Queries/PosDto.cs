using AutoMapper;
using Lezizz.Core.ApplicationService.Common.Mappings;
using Lezizz.Core.Domain.Entities;
using System;

namespace Lezizz.Core.ApplicationService.Poses.Queries
{
    public class PosDto : IMapFrom<Pos>
    {
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
        public string InvoiceType { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Pos, PosDto>()
                .ForMember(d => d.InvoiceType, opt => opt.MapFrom(s => s.EnglishName));
        }
    }
}