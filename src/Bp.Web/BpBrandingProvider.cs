using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Bp.Web
{
    [Dependency(ReplaceServices = true)]
    public class BpBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Bp";
    }
}
