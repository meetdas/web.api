using Microsoft.EntityFrameworkCore;
using web.Api.Models;

namespace web.Api.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
           : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
    }
}
