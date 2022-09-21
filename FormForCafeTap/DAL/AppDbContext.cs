using FormForCafeTap.Models;
using Microsoft.EntityFrameworkCore;

namespace FormForCafeTap.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Form> Forms { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<University> Universities { get; set; }

    }
}
