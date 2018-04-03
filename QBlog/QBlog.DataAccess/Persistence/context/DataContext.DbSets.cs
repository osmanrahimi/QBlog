using Microsoft.EntityFrameworkCore;
using QBlog.Core.Entities;

namespace QBlog.DataAccess.Persistence
{
    public partial class DataContext
    {
        public DbSet<PostEntity> Posts { get; set; }
    }
}