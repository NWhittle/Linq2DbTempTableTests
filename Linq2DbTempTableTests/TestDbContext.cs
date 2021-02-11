using Microsoft.EntityFrameworkCore;

namespace Linq2DbTempTableTests
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        public TestDbContext()
        {
        }
    }
}
