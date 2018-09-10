using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABP_CORE_MPA.EntityFrameworkCore
{
    public static class ABP_CORE_MPADbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABP_CORE_MPADbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABP_CORE_MPADbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
