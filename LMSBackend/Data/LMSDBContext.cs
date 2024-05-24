using LMSBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace LMSBackend.Data
{
    public class LMSDBContext: DbContext
    {
        public LMSDBContext(DbContextOptions<LMSDBContext> options) : base(options) { }
        public DbSet<Users> Users { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Author> Authors { get; set; }
    }
}
