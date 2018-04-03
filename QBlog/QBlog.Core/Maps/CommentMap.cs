using Microsoft.EntityFrameworkCore;
using QBlog.Core.Entities;

namespace QBlog.Core.Maps
{
    public class CommentMap : IEntityMap
    {
        public CommentMap(ModelBuilder builder)
        {
            builder.Entity<CommentEntity>(e =>
            {
                e.ToTable("Comment");
                e.Property(c => c.Body).IsRequired();
                e.Property(c => c.BrowserName).IsRequired();
                e.Property(c => c.Email).IsRequired().HasMaxLength(25);
                e.Property(c => c.ClientIP).IsRequired().HasMaxLength(20);

                e.HasOne(c => c.Post).WithMany(c => c.Comments).HasForeignKey(c => c.PostId).OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}