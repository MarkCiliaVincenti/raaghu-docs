using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace raaghuDocumentation.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class raaghuDocumentationDbContextFactory : IDesignTimeDbContextFactory<raaghuDocumentationDbContext>
{
    public raaghuDocumentationDbContext CreateDbContext(string[] args)
    {
        raaghuDocumentationEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<raaghuDocumentationDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new raaghuDocumentationDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../raaghuDocumentation.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
