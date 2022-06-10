// See https://aka.ms/new-console-template for more information

using AbpDaprActorInterfaces;
using Dapr.Actors;
using Dapr.Actors.Client;

Console.WriteLine("Startup up...");

// Registered Actor Type in Actor Service
var actorType = "MyActor";

// An ActorId uniquely identifies an actor instance
// If the actor matching this id does not exist, it will be created
var actorId = new ActorId("1");

// Create the local proxy by using the same interface that the service implements.
//
// You need to provide the type and id so the actor can be located. 
var proxy = ActorProxy.Create<IMyActor>(actorId, actorType);

// Now you can use the actor interface to call the actor's methods.
Console.WriteLine($"Calling SetDataAsync on {actorType}:{actorId}...");
var response = await proxy.PingAsync();
Console.WriteLine($"Got response: {response}");
