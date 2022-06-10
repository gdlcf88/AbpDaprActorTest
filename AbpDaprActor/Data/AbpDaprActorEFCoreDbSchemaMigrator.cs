using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace AbpDaprActor.Data;

public class AbpDaprActorEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public AbpDaprActorEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpDaprActorDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpDaprActorDbContext>()
            .Database
            .MigrateAsync();
    }
}
