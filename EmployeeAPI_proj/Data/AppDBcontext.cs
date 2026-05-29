using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI_proj.Data
{
    public class AppDBcontext : DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options)
        {
        }
    }
}
