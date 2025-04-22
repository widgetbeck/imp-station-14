namespace Content.Server._Impstation.BecksExample;

[RegisterComponent]
public sealed partial class BecksExampleComponent : Component
{
    /// <summary>
    /// Stores the UID of the person who currently has this equipped
    /// </summary>
    public EntityUid? CurrentlyEquipped = null;
}
