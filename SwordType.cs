public class SwordType : SwordComponent
{
    public string TypeText { get; init; }

    public SwordType(SwordComponent component, string Type) : base(component) =>
        TypeText = Type;

    public override string ToString() => $"{TypeText}{WeaponComponent.ToString()}";
}