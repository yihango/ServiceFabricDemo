using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABP_CORE_MPA.Configuration;
using ABP_CORE_MPA.Web;

namespace ABP_CORE_MPA.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABP_CORE_MPADbContextFactory : IDesignTimeDbContextFactory<ABP_CORE_MPADbContext>
    {
        public ABP_CORE_MPADbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABP_CORE_MPADbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABP_CORE_MPADbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABP_CORE_MPAConsts.ConnectionStringName));

            return new ABP_CORE_MPADbContext(builder.Options);
        }
    }
}
