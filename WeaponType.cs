namespace EdgeGen
{
    public class WeaponType
    {
        public static string[] Descriptors = new string[] {
            "{{WORN}}worn", "{{INFUSION}}-infused",
            "{{FORGED}}-forged", "{{CURSED}}-cursed",
            "massive", "ancient", "military",  "antique", "arcane", "attuned",
            "whistling",  "bronze", "blessed", "baneful", "barbaric",  "ghastly",
            "corroded", "brutal", "crazed", "crying", "singing", "dancing", "defiled",
            "demonic", "hateful", "hungering", "gleaming", "glinting", "greedy", "skeletal",
            "grieving", "primitive", "promised", "improved", "haunted", "heartless",
            "rusty", "wicked", "exalted", "adamantite", "bronzed", "hardened", "obsidian",
            "supreme", "perfected"
        };

        public static string[] Infusion = new string[] {
            "ruby", "emerald", "sapphire", "bood", "shadow", "death", "jade", "amathyst",
            "amber", "rune", "fire", "wind", "water", "earth", "light", 
        };

        public static string[] Worn = new string[] {
            "battle", "war", "age", "time"
        };

        public static string[] Forged = new string[] {
            "blood", "war", "battle", "cold", "hell", "soul", "ghost", "storm", "spectral",
            "aether", "wind", "thunder", "rune",
        };

        public static string[] Cursed = new string[] {
            "blood", "thrice", "soul", "devil"
        };

        public static string[] Type = new string[] {
            "blade", "broadsword", "claymore", "defender", "deflector", "{{TITLE_1}}blade", "greatsword", "guardian",
            "katana", "longsword", "protector", "rapier", "reaver", "sabre", "scimitar", "shortsword", "slicer", "sword",
            "skewer", "carver", "etcher", "eculptor", "razor", "crusader", "blade", "blade", "edge",
        };

        public static string Get_Description()
        {
            var desc = Program.GetRand(Descriptors);
            desc = desc.Replace("{{WORN}}", Program.GetRand(Worn));
            desc = desc.Replace("{{INFUSION}}", Program.GetRand(Infusion));
            desc = desc.Replace("{{FORGED}}", Program.GetRand(Forged));
            desc = desc.Replace("{{CURSED}}", Program.GetRand(Cursed));
            return desc;
        }

        public static string Get_Type()
        {
            var type = Program.GetRand(Type);
            type = type.Replace("{{TITLE_1}}", Program.GetRand(WeaponTitle.Title_Compound_1));
            return type;
        }

        public static string Generate() =>
            $"{Get_Description()} {Get_Type()}";
    }
}