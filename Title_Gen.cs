using System;

namespace EdgeGen
{
    public class Sword_Gen
    {
        public static Random rand = new Random();

        public static T GetRand<T>(T[] collection)
        {
            return collection[rand.Next(collection.Length)];
        }

        public static string[] Title_Prefix = new string[] {
            "angel's", "demon's", "abyssal", "tenfold", "thousandfold",
            "grave's", "blind", "broken", "chaos'", "comet's", "corruption's",
            "divine", "destiny's", "eclipse", "champion's ", "fallen ",
            "king's", "final", "hatred's", "knight's", "hell's", "hollow",
            "interrogator", "hope's", "last", "misery's", "perfect",
            "ultimate", "silver", "recruit's", "oathkeeper's", "bandit's",
            "alpha", "beta", "omega", "gamma", "lich's", "liar's"
        };

        public static string[] Title_Completes = new string[] {
            "assurance", "apocalypse", "armageddon", "aetherius",
            "amnesia", "betrayer", "cataclysm", "brutality", "catastrophe",
            "celeste", "convergence", "corruption", "darkness", "dawn",
            "decimation", "desolation", "despair", "devourer", "epilogue",
            "espada", "harmony", "extinction", "frenzy", "florence", 
            "bite", "hellfire", "silence", "end", "infamy", "interrogator",
            "defender", "rites", "nirvana", "rage", "oblivion", "purifier",
            "complement"
        };

        public static string[] Title_Part_1 = new string[] {
            "shadow", "thunder", "azure", "black", "aether", "grave",
            "blaze", "blink", "blood", "dark", "chaos", "comet", "troll",
            "dawn", "death", "sword", "doom", "draught", "echo", "end",
            "faith", "flesh", "ghost", "grass", "god", "gut", "heart",
            "kin", "hell", "oath", "night", "fel", "world", "will",
            "winter", "venom", "storm", "skull", "soul", "rage",
            "alpha", "beta", "omega", "sun", "lich", "war", "battle",
            "void", "mage", "quick", "spell"
        };

        public static string[] Title_Part_2 = new string[] {
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

        public static string[] Descriptors = new string[] {
            "{{WORN}}worn", "{{INFUSION}}-infused",
            "{{FORGED}}-forged", "{{CURSED}}-cursed",
            "massive", "ancient", "military",  "antique", "arcane", "attuned",
            "whistling",  "bronze", "blessed", "baneful", "barbaric",  "ghastly",
            "corroded", "brutal", "crazed", "crying", "singing", "dancing", "defiled",
            "demonic", "hateful", "hungering", "gleaming", "glinting", "greedy", "skeletal",
            "grieving", "primitive", "promised", "improved", "haunted", "heartless",
            "rusty", "wicked", "exalted", "adamantite", "bronzed", "hardened", "obsidian",
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

        public static string[] Flair = new string[] {
            "ancient {{FLAIR1}}", "broken {{FLAIR1}}", "blessed {{FLAIR1}}", "dark {{FLAIR1}}",
            "closing {{FLAIR1}}", "conquered {{FLAIR1}}", "eternal {{FLAIR1}}", "timeless {{FLAIR1}}",
            "time-lost {{FLAIR1}}", "trembling {{FLAIR1}}", "unholy {{FLAIR1}}", "holy {{FLAIR1}}",
            "twilight's {{FLAIR1}}", "pride's {{FLAIR1}}", "traitor's {{FLAIR1}}", "hell's {{FLAIR1}}",
            "heaven's {{FLAIR1}}",
            
            "wind{{FLAIR2}}", "storm{{FLAIR2}}", "day{{FLAIR2}}", "night{{FLAIR2}}", "moon{{FLAIR2}}",
            
            "the shifting {{FLAIR3}}", "twisting {{FLAIR3}}", "corrupted {{FLAIR3}}", "blighted {{FLAIR3}}",
            "the burning {{FLAIR3}}", "frozen {{FLAIR3}}", "radiant {{FLAIR3}}", "high {{FLAIR3}}",

            "the leviathan", "the light", "the lion", "the lone victor", "the lone wolf", "the king",
            "the gladiator", "the fallen", "the covanent", "the crown", "the damned",
        };

        public static string[] Flair1 = new string[] {
            "magic", "power", "fortune", "bones", "dreams", "eyes", "worlds",
            "delusions", "denial", "sorrow", "struggle", "games", "misery",
            "might"
        };

        public static string[] Flair2 = new string[] {
            "seeker", "walker", "treader", "wanderer", "dreams", "voices"
        };

        public static string[] Flair3 = new string[] {
            "sands", "worlds", "hells", "heavens"
        };

        public static string Get_Prefix() =>
            GetRand(Title_Prefix);

        public static string Get_Title()
        {
            if(rand.Next(2) == 0)
            {
                return GetRand(Title_Completes);
            }
            return $"{ GetRand(Title_Part_1) }{ GetRand(Title_Part_2) }";
        }

        public static string Get_Description()
        {
            var desc = GetRand(Descriptors);
            desc = desc.Replace("{{WORN}}", GetRand(Worn));
            desc = desc.Replace("{{INFUSION}}", GetRand(Infusion));
            desc = desc.Replace("{{FORGED}}", GetRand(Forged));
            desc = desc.Replace("{{CURSED}}", GetRand(Cursed));
            return desc;
        }

        public static string Get_Type()
        {
            var type = GetRand(Type);
            type = type.Replace("{{TITLE_1}}", GetRand(Title_Part_1));
            return type;
        }

        public static string Get_Flair()
        {
            var flair = GetRand(Flair);
            flair = flair.Replace("{{FLAIR1}}", GetRand(Flair1));
            flair = flair.Replace("{{FLAIR2}}", GetRand(Flair2));
            flair = flair.Replace("{{FLAIR3}}", GetRand(Flair3));
            return flair;
        }
    }

    
}