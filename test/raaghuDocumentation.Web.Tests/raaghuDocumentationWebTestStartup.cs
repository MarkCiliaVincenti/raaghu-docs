using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace raaghuDocumentation;

public class raaghuDocumentationWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<raaghuDocumentationWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
