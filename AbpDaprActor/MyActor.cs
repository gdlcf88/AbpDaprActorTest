using AbpDaprActorInterfaces;
using Dapr.Actors.Runtime;

namespace AbpDaprActor;

public class MyActor : Actor, IMyActor
{
    public MyActor(ActorHost host) : base(host)
    {
    }

    public Task<string> PingAsync()
    {
        return Task.FromResult("Pong");
    }
}