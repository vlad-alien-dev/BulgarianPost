using Bp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Bp.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class BpPageModel : AbpPageModel
    {
        protected BpPageModel()
        {
            LocalizationResourceType = typeof(BpResource);
        }
    }
}