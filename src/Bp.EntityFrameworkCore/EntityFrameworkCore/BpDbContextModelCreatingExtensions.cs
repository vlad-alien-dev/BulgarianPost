using Bp.Domain;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Bp.EntityFrameworkCore
{
    public static class BpDbContextModelCreatingExtensions
    {
        public static void ConfigureBp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));


            builder.Entity<Article>(b =>
            {
                b.ToTable(BpConsts.DbTablePrefix + "Articles", BpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Title).IsRequired().HasMaxLength(1024);
            });
        }
    }
}