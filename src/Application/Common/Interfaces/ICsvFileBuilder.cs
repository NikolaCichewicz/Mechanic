using Mechanic.Application.TodoLists.Queries.ExportTodos;

namespace Mechanic.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
