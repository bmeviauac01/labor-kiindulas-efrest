using Bme.Swlab1.Rest.Dal;
using Bme.Swlab1.Rest.Dtos;

namespace Bme.Swlab1.Rest.Services;

public class StatusService : IStatusService
{
    private readonly TasksDbContext _dbContext;

    public StatusService(TasksDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public bool ExistsWithName(string statusName)
    {
        throw new NotImplementedException();
    }

    public Status FindById(int statusId)
    {
        throw new NotImplementedException();
    }

    public Status Insert(CreateStatus value)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyCollection<Status> List()
    {
        throw new NotImplementedException();
    }
}
