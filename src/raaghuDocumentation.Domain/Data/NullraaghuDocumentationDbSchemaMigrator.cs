using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace raaghuDocumentation.Data;

/* This is used if database provider does't define
 * IraaghuDocumentationDbSchemaMigrator implementation.
 */
public class NullraaghuDocumentationDbSchemaMigrator : IraaghuDocumentationDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
