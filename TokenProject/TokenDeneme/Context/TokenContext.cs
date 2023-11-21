using Microsoft.EntityFrameworkCore;
using TokenProject.Entity;

namespace TokenProject.Context
{
    public class TokenContext: DbContext
    {
        public TokenContext(DbContextOptions<TokenContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
