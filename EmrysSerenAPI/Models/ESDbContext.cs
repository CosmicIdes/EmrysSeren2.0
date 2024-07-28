using EmrysSerenShared;
using Microsoft.EntityFrameworkCore;

namespace EmrysSerenAPI.Models
{
    public class ESDbContext : DbContext
    {
        public ESDbContext(DbContextOptions<ESDbContext> options) : base(options)
        {

        }

        public DbSet<BlogPost> BlogPosts { get; set; }  
        public DbSet<CommentPost> CommentPosts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
