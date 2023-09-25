using raaghuDocumentation.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace raaghuDocumentation.Web.Pages;

public abstract class raaghuDocumentationPageModel : AbpPageModel
{
    protected raaghuDocumentationPageModel()
    {
        LocalizationResourceType = typeof(raaghuDocumentationResource);
    }
}
