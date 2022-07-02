namespace EdgeGen
{
    public class Afffix : IWeaponPart
    {
        public Afffix Link_After;
        public string Text { get; init; }

        public Afffix(string Text) => this.Text = Text;

        public Afffix Chain(Afffix part)
        {
            if(Link_After == null)
            {
                Link_After = part;
                return part;
            }
            return Link_After.Chain(part);
        }

        public override string ToString() => Link_After?.ToString() ?? "" + Text; 
    }
}