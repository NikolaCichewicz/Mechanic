using Mechanic.Application.Common.Mappings;
using Mechanic.Domain.Entities;

namespace Mechanic.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
