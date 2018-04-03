using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace QBlog.Core.Maps
{
    public class IdentityMap : IEntityMap
    {
        public IdentityMap(ModelBuilder builder)
        {
            builder.Entity<IdentityUser<int>>(e => e.ToTable("Users"));

            builder.Entity<IdentityUserClaim<int>>(e => e.ToTable("UserClaims"));

            builder.Entity<IdentityUserRole<int>>(e => e.ToTable("UserRoles"));

            builder.Entity<IdentityUserLogin<int>>(e => e.ToTable("UserLogins"));

            builder.Entity<IdentityUserToken<int>>(e => e.ToTable("UserTokens"));

            builder.Entity<IdentityRole<int>>(e => e.ToTable("Roles"));

            builder.Entity<IdentityRoleClaim<int>>(e => e.ToTable("RoleClaims"));
        }
    }
}