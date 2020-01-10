using MediatR;
using Lezizz.Core.ApplicationService.Common.Interfaces;
using Lezizz.Core.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Lezizz.Core.ApplicationService.TodoItems.Commands.CreateTodoItem
{
    public class CreateTodoItemCommand : IRequest<long>
    {
        public int ListId { get; set; }

        public string Title { get; set; }

        public class CreateTodoItemCommandHandler : IRequestHandler<CreateTodoItemCommand, long>
        {
            private readonly IApplicationDbContext _context;

            public CreateTodoItemCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<long> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
            {
                var entity = new TodoItem
                {
                    ListId = request.ListId,
                    Title = request.Title,
                    Done = false
                };

                _context.TodoItems.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return entity.Id;
            }
        }
    }
}
