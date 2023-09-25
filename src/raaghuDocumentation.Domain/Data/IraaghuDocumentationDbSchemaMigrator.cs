using System.Threading.Tasks;

namespace raaghuDocumentation.Data;

public interface IraaghuDocumentationDbSchemaMigrator
{
    Task MigrateAsync();
}
