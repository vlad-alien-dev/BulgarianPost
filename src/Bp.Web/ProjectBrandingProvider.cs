using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Bp.Web
{
    [Dependency(ReplaceServices = true)]
    public class ProjectBrandingProvider: DefaultBrandingProvider
    {
        public override string AppName => "Bulgarian Post";

    }
}
