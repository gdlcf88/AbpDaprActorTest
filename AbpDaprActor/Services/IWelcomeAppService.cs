namespace AbpDaprActor.Services;

public interface IWelcomeAppService
{
    Task<string> HelloAsync();
}