namespace EdgeGen
{
    public class WeaponTitle
    {
        public static string[] Prefix_Possibles = new string[] {
            "angel's", "demon's", "abyssal", "tenfold", "thousandfold",
            "grave's", "blind", "broken", "chaos'", "comet's", "corruption's",
            "divine", "destiny's", "eclipse", "champion's", "fallen",
            "king's", "final", "hatred's", "knight's", "hell's", "hollow",
            "interrogator", "hope's", "last", "misery's", "perfect",
            "ultimate", "silver", "recruit's", "oathkeeper's", "bandit's",
            "alpha", "beta", "omega", "gamma", "lich's", "liar's", "perfected"
        };

        public static string[] Title_Possibles = new string[] {
            "assurance", "apocalypse", "armageddon", "aetherius",
            "amnesia", "betrayer", "cataclysm", "brutality", "catastrophe",
            "celeste", "convergence", "corruption", "darkness", "dawn",
            "decimation", "desolation", "despair", "devourer", "epilogue",
            "espada", "harmony", "extinction", "frenzy", "florence", 
            "bite", "hellfire", "silence", "end", "infamy", "interrogator",
            "defender", "rites", "nirvana", "rage", "oblivion", "purifier",
            "complement", "hyperion"
        };

        public static string[] Title_Compound_1 = new string[] {
            "shadow", "thunder", "azure", "black", "aether", "grave",
            "blaze", "blink", "blood", "dark", "chaos", "comet", "troll",
            "dawn", "death", "sword", "doom", "draught", "echo", "end",
            "faith", "flesh", "ghost", "grass", "god", "gut", "heart",
            "kin", "hell", "oath", "night", "fel", "world", "will",
            "winter", "venom", "storm", "skull", "soul", "rage",
            "alpha", "beta", "omega", "sun", "lich", "war", "battle",
            "void", "mage", "quick", "spell"
        };

        public static string[] Title_Compound_2 = new string[] {
            "wrath", "fury", "heart", "shard", "guard", "strike", "thirster",
            "quench", "fell", "feller", "breaker", "smasher", "bringer",
            "raze", "eater", "blight", "fate", "plight", " justice",
            " devourer", " promise", "blade", "light", "song", "singer",
            "bane", "keeper", "render", "rend", " reaver", "walker", "slayer",
            "cutter", "fire", "striker", "scream", "drinker", "keeper",
            "crackle", "edge", "razor", "fall", "thorn", "breaker",
            "monger", "shank", "caller", "crusher", "steel", "boon",
            "glaive", "sigil"
        };

        public static string Get_Prefix() =>
            Program.GetRand(Prefix_Possibles);

        public static string Get_Title() =>
            Program.GetRand(Title_Possibles);

        public static string Get_Compound() =>
            $"{ Program.GetRand(Title_Compound_1) }{ Program.GetRand(Title_Compound_2) }";

        public static string Generate()
        {
            string title = "";
            if(Program.CoinFilp())
                title += Get_Prefix() + " ";

            if(Program.CoinFilp())
                title += Get_Title();
            else
                title += Get_Compound();
            
            return title;
        }
    }
}