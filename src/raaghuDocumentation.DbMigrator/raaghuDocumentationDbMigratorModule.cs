using raaghuDocumentation.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace raaghuDocumentation.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(raaghuDocumentationEntityFrameworkCoreModule),
    typeof(raaghuDocumentationApplicationContractsModule)
)]
public class raaghuDocumentationDbMigratorModule : AbpModule
{
}
