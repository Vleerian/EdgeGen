public class SwordPartBase : SwordComponent
{
    public readonly string BaseText;

    public SwordPartBase(string Base) : base (null) =>
        BaseText = Base;

    public override string ToString() => BaseText;
}