using Microsoft.EntityFrameworkCore;

namespace Datadriven.Lab.Rest.Dal;

public class TasksDbContext : DbContext
{
    // DO NOT CHANGE THE CONSTRUCTOR - NE VALTOZTASD MEG A KONSTRUKTORT
    public TasksDbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // TODO
    }
}
