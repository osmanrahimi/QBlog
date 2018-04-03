using Microsoft.EntityFrameworkCore;
using QBlog.Core.Entities;

namespace QBlog.DataAccess.Persistence
{
    public interface IUnitOfWork
    {
        void Commit();

        DbSet<T> Set<T>() where T : BaseEntity;
    }
}