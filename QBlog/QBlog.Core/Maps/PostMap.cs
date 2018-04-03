using Microsoft.EntityFrameworkCore;
using QBlog.Core.Entities;

namespace QBlog.Core.Maps
{
    public class PostMap : IEntityMap
    {
        public PostMap(ModelBuilder builder)
        {
            builder.Entity<PostEntity>(e =>
            {
                e.ToTable("Post");
                e.Property(c => c.Title).IsRequired().HasMaxLength(255);
                e.Property(p => p.Body).IsRequired().IsRequired();
                e.Property(p => p.CreatedOn).IsRequired();
            });
        }
    }
}