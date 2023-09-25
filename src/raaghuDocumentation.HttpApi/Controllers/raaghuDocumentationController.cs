using raaghuDocumentation.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace raaghuDocumentation.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class raaghuDocumentationController : AbpControllerBase
{
    protected raaghuDocumentationController()
    {
        LocalizationResource = typeof(raaghuDocumentationResource);
    }
}
