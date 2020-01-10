using Lezizz.Core.Domain.Common;
using System.Collections.Generic;

namespace Lezizz.Core.Domain.Entities
{
    public class TodoList : AuditableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Colour { get; set; }

        public ICollection<TodoItem> Items { get; set; } = new List<TodoItem>();
    }
}
