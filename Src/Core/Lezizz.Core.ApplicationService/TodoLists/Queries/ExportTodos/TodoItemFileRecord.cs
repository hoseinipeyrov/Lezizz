using Lezizz.Core.ApplicationService.Common.Mappings;
using Lezizz.Core.Domain.Entities;

namespace Lezizz.Core.ApplicationService.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
