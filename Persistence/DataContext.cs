
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    /// <summary>
    /// represent a session with the DB 
    /// </summary>
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
