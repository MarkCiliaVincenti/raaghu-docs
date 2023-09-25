using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using raaghuDocumentation.Data;
using Volo.Abp.DependencyInjection;

namespace raaghuDocumentation.EntityFrameworkCore;

public class EntityFrameworkCoreraaghuDocumentationDbSchemaMigrator
    : IraaghuDocumentationDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreraaghuDocumentationDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the raaghuDocumentationDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<raaghuDocumentationDbContext>()
            .Database
            .MigrateAsync();
    }
}
