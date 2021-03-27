using api.Controllers.Dto;
using api.Model;
using System.Collections.Generic;

namespace api.DAL
{
    // DO NOT MODIFY THE EXISTING METHODS
    // NE VALTOZTASD MEG A MEGLEVO FUGGVENYEKET
    public interface ITasksRepository
    {
        IReadOnlyCollection<Task> List();
        Task FindById(int taskId);
        Task Insert(CreateTask value);
        Task Delete(int taskId);

        Task MarkDone(int taskId);
        Task MoveToStatus(int taskId, string newStatusName);
    }
}
