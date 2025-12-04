using Datadriven.Lab.Rest.Dtos;

using Task = Datadriven.Lab.Rest.Dtos.Task;

namespace Datadriven.Lab.Rest.Services;

// DO NOT MODIFY THE EXISTING METHODS
// but you could extend this interface
// 
// NE VALTOZTASD MEG A MEGLEVO FUGGVENYEKET,
// de kigészítheted az interfészt
public interface ITaskService
{
    IReadOnlyCollection<Task> List();
    Task FindById(int taskId);
    Task Insert(CreateTask value);
    Task Delete(int taskId);

    Task MarkDone(int taskId);
    Task MoveToStatus(int taskId, string newStatusName);
}
