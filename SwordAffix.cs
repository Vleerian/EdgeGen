public class SwordAffix : SwordComponent
{
    public string AffixText { get; init; }

    public SwordAffix(SwordComponent component, string Title) : base(component) =>
        AffixText = Title;

    public override string ToString() => $"{WeaponComponent.ToString()} {AffixText}";
}