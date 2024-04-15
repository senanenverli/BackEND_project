using Microsoft.EntityFrameworkCore;

namespace BACKEND_PROJECT.Contexts;

public class RiodeDbContext : DbContext
{
    public RiodeDbContext(DbContextOptions options) : base(options)
    {
    }



}
