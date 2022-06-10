using Volo.Abp.Application.Services;

namespace AbpDaprActor.Services;

public class WelcomeAppService : ApplicationService, IWelcomeAppService
{
    public Task<string> HelloAsync()
    {
        return Task.FromResult("World");
    }
}