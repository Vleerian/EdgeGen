namespace EdgeGen
{
    public class Sword : IWeapon
    {
        public Prefix Prefix { get; init; }
        public SwordType Type { get; init; }
        public Afffix Affix { get; init; }

        public override string ToString() =>
            $"{Prefix} {Type} {Affix}";
    }
}