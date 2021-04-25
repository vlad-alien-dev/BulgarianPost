using System.Threading.Tasks;
using Bp.Localization;
using Bp.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Bp.Web.Menus
{
    public class BpMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var administration = context.Menu.GetAdministration();
            var l = context.GetLocalizer<BpResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    BpMenus.Home,
                    l["Menu:Home"],
                    "~/",
                    icon: "fas fa-home",
                    order: 0
                )
            );
            context.Menu.AddItem(
                new ApplicationMenuItem(
                    name: "ArticlesArchive",
                    displayName: l["Menu:ArticlesArchive"],
                    icon: "fa fa-book"
                    ).AddItem(
                        new ApplicationMenuItem(
                        name: "ArticlesArchive.Articles",
                        displayName: l["Menu:Articles"],
                        url:"/Articles")
                    )
                );

            if (MultiTenancyConsts.IsEnabled)
            {
                administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
            }
            else
            {
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
            administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
        }
    }
}
