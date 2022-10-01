public class Sword : SwordComponent
{
    public readonly string SwordName;

    public Sword(string Name) : base (null) =>
        SwordName = Name;

    public override string ToString() => SwordName;
}