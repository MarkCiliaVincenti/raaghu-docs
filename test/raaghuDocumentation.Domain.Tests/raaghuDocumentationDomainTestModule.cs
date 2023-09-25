using raaghuDocumentation.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace raaghuDocumentation;

[DependsOn(
    typeof(raaghuDocumentationEntityFrameworkCoreTestModule)
    )]
public class raaghuDocumentationDomainTestModule : AbpModule
{

}
