using api.Controllers.Dto;
using api.Model;
using System.Collections.Generic;

namespace api.DAL
{
    // DO NOT MODIFY THE EXISTING METHODS
    // NE VALTOZTASD MEG A MEGLEVO FUGGVENYEKET
    public interface IStatusesRepository
    {
        IReadOnlyCollection<Status> List();
        bool ExistsWithName(string statusName);
        Status FindById(int statusId);
        Status Insert(CreateStatus value);
    }
}
