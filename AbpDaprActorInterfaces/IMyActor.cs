using Dapr.Actors;

namespace AbpDaprActorInterfaces;

public interface IMyActor : IActor
{
    Task<string> PingAsync();
}