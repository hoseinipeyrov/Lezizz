using Lezizz.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Lezizz.Core.ApplicationService.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<TodoList> TodoLists { get; set; }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Pos> Poses { get; set; }
        public DbSet<Food> Foods { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
