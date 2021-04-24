using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Bp.EntityFrameworkCore
{
    [DependsOn(
        typeof(BpEntityFrameworkCoreModule)
        )]
    public class BpEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BpMigrationsDbContext>();
        }
    }
}
