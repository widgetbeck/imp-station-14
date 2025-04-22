using Content.Shared.Inventory.Events;

namespace Content.Server._Impstation.BecksExample;

public sealed class BecksExampleSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<BecksExampleComponent, GotEquippedEvent>(OnGotEquipped);
        SubscribeLocalEvent<BecksExampleComponent, GotUnequippedEvent>(OnGotUnequipped);
    }

    private void OnGotEquipped(Entity<BecksExampleComponent> ent, ref GotEquippedEvent args)
    {
        ent.Comp.CurrentlyEquipped = args.Equipee;
    }

    private void OnGotUnequipped(Entity<BecksExampleComponent> ent, ref GotUnequippedEvent args)
    {
        ent.Comp.CurrentlyEquipped = null;
    }

    public override void Update(float frameTime)
    {
        base.Update(frameTime);

        var enumerator = EntityQueryEnumerator<BecksExampleComponent>();

        while (enumerator.MoveNext(out _, out var comp))
        {

        }
    }
}
