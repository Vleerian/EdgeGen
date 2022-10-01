public class SwordTitle : SwordComponent
{
    public string TitleText { get; init; }

    public SwordTitle(SwordComponent component, string Title) : base(component) =>
        TitleText = Title;

    public override string ToString() => $"{TitleText}, {WeaponComponent.ToString()}";
}