using AbpDaprActor.Localization;
using Volo.Abp.UI.Navigation;

namespace AbpDaprActor.Menus;

public class AbpDaprActorMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<AbpDaprActorResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                AbpDaprActorMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        return Task.CompletedTask;
    }
}
