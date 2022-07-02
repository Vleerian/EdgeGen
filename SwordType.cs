namespace EdgeGen
{
    public class SwordType : IWeaponPart
    {
        public Material Material { get; init; }
        public string Text { get; init; }

        public SwordType(string Text) => this.Text = Text;

        public override string ToString() =>
            Material?.ToString() ?? "" + Text;
    }
}