namespace EdgeGen
{
    public class Prefix : IWeaponPart
    {
        public Prefix Link_After;
        public string Text { get; init; }

        public Prefix(string Text) => this.Text = Text;

        public Prefix Chain(Prefix part)
        {
            if(Link_After == null)
            {
                Link_After = part;
                return this;
            }
            Link_After.Chain(part);
            return this;
        }

        public override string ToString() => Text +  (Link_After != null ? " " + Link_After: "") ; 
    }
}