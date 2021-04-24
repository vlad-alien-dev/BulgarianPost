using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Bp.EntityFrameworkCore
{
    public static class BpDbContextModelCreatingExtensions
    {
        public static void ConfigureBp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BpConsts.DbTablePrefix + "YourEntities", BpConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}