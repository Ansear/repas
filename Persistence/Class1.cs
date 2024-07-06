using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace Persistence
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        { }
    }
}
