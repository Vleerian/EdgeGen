public class SwordModifier : SwordComponent
{
    public string ModifierText { get; init; }

    public SwordModifier(SwordComponent component, string Title) : base(component) =>
        ModifierText = Title;

    public override string ToString() => $"{ModifierText} {WeaponComponent.ToString()}";
}