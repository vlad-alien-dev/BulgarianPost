using Microsoft.EntityFrameworkCore;
using Bp.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;
using Bp.Domain;

namespace Bp.EntityFrameworkCore
{

    [ConnectionStringName("Default")]
    public class BpDbContext : AbpDbContext<BpDbContext>
    {
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Article> Articles { get; set; }


        public BpDbContext(DbContextOptions<BpDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser
                
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the BpEfCoreEntityExtensionMappings class
                 */
            });

            /* Configure your own tables/entities inside the ConfigureBp method */

            builder.ConfigureBp();
        }
    }
}
