using FluentValidation;
using Lezizz.Core.ApplicationService.Common.Interfaces;
using Lezizz.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lezizz.Core.ApplicationService.Poses.Commands
{
    public class CreatePosCommand : IRequest<int>
    {
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


    }
    public class CreatePosCommandHandler : IRequestHandler<CreatePosCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreatePosCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreatePosCommand request, CancellationToken cancellationToken)
        {
            var entity = new Pos
            {
                PersianName = request.PersianName,
                EnglishName = request.EnglishName,
                TablesCount = request.TablesCount,
                SeatsCount = request.SeatsCount,
                ServiceChargePercent = request.ServiceChargePercent,
                TaxChangePercent = request.TaxChangePercent,
                VatChangePercent = request.VatChangePercent,
                TicketNumber = request.TicketNumber,
                TicketNoDailyReset = request.TicketNoDailyReset,
                InvoiceType = request.InvoiceType
            };

            _context.Poses.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.PosId;
        }
    }

    public class CreatePosCommandValidator : AbstractValidator<CreatePosCommand>
    {
        public CreatePosCommandValidator()
        {
            RuleFor(v => v.PersianName)
                .MinimumLength(3)
                .MaximumLength(200)
                .NotEmpty();
        }
    }
}
