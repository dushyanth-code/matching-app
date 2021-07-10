using Microsoft.EntityFrameworkCore;
using src.Entities;

namespace src.Data
{
    public class Mycontext : DbContext
    {
        public Mycontext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }
    }
}