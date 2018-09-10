using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABP_CORE_MPA.Authorization.Roles;
using ABP_CORE_MPA.Authorization.Users;
using ABP_CORE_MPA.MultiTenancy;

namespace ABP_CORE_MPA.EntityFrameworkCore
{
    public class ABP_CORE_MPADbContext : AbpZeroDbContext<Tenant, Role, User, ABP_CORE_MPADbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABP_CORE_MPADbContext(DbContextOptions<ABP_CORE_MPADbContext> options)
            : base(options)
        {
        }
    }
}
