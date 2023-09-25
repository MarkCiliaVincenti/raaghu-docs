using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace raaghuDocumentation.Web;

[Dependency(ReplaceServices = true)]
public class raaghuDocumentationBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "raaghuDocumentation";
}
