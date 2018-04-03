using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QBlog.Core;
using QBlog.Core.Entities;
using QBlog.Core.Maps;
using System;
using System.Linq;
using System.Reflection;

namespace QBlog.DataAccess.Persistence
{
    public partial class DataContext : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=qblog;User ID=sa;Password=1;MultipleActiveResultSets=True;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            RegisterEntityMaps(builder);

            base.OnModelCreating(builder);
            new IdentityMap(builder);
        }

        private void RegisterEntityMaps(ModelBuilder builder)
        {
            Assembly assembly = typeof(PostEntity).Assembly;

            var maps = assembly.GetTypes()
                                 .Where(type => !string.IsNullOrWhiteSpace(type.Namespace) && typeof(IEntityMap).IsAssignableFrom(type) && type.IsClass)
                                 .ToList();

            foreach (var item in maps)
                Activator.CreateInstance(item, BindingFlags.Public | BindingFlags.Instance, null, new object[] { builder }, null);
        }
    }
}