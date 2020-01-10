using Lezizz.Core.ApplicationService.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace Lezizz.Core.ApplicationService.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
