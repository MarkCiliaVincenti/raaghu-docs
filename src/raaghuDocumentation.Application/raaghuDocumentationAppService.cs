using raaghuDocumentation.Localization;
using Volo.Abp.Application.Services;

namespace raaghuDocumentation;

/* Inherit your application services from this class.
 */
public abstract class raaghuDocumentationAppService : ApplicationService
{
    protected raaghuDocumentationAppService()
    {
        LocalizationResource = typeof(raaghuDocumentationResource);
    }
}
