namespace EdgeGen
{
    public class Material : IWeaponPart
    {
        public Material Alloy { get; init; }
        public string Text { get; init; }

        public override string ToString() =>
            (Alloy != null ? Alloy.ToString() + "-" : "") + Text;
    }
}