using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpDaprActor;

[Dependency(ReplaceServices = true)]
public class AbpDaprActorBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpDaprActor";
}
