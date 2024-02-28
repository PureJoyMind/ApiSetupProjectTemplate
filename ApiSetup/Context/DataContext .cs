using Microsoft.EntityFrameworkCore;

namespace TrackerService.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    // Define DbSets for EF Core
    //public DbSet<DBOModel> User { get; set; } = null!;
    

}