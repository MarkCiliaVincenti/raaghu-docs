using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.UI.Layout;
using raaghuDocumentation.Web.Menus;

namespace raaghuDocumentation.Web;

[Dependency(ReplaceServices = true)]
public class raaghuDocumentationBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Documentation Center | Raaghu.io";
}