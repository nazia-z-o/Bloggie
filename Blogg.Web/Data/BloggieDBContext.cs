using Blogg.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blogg.Web.Data
{
    public class BloggieDBContext:DbContext
    {
        public BloggieDBContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
