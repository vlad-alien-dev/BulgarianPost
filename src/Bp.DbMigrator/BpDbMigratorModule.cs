using Bp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Bp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(BpEntityFrameworkCoreDbMigrationsModule),
        typeof(BpApplicationContractsModule)
        )]
    public class BpDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
