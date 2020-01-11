using AutoMapper;
using AutoMapper.QueryableExtensions;
using Lezizz.Core.ApplicationService.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Lezizz.Core.ApplicationService.Poses.Queries
{
    public class GetPosQuery : IRequest<PosVm>
    {
        public class GetPosQueryHandler : IRequestHandler<GetPosQuery, PosVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetPosQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<PosVm> Handle(GetPosQuery request, CancellationToken cancellationToken)
            {
                PosVm vm = new PosVm
                {
                    PosList = await _context.Poses.ProjectTo<PosDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
                };

                return vm;
            }
        }
    }
}
