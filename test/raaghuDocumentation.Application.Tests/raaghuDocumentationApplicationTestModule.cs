using Volo.Abp.Modularity;

namespace raaghuDocumentation;

[DependsOn(
    typeof(raaghuDocumentationApplicationModule),
    typeof(raaghuDocumentationDomainTestModule)
    )]
public class raaghuDocumentationApplicationTestModule : AbpModule
{

}
