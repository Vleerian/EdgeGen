namespace EdgeGen
{
    public class WeaponFlair
    {
        public static string[] Flair_Prefix = new string[] {
            "harbinger", "herald", "forteller", "precusor", "origin", "bringer",
            "master", "progenitor", "wielder", "destroyer",
        };

        public static string[] Flair = new string[] {
            "ancient {{FLAIR1}}", "broken {{FLAIR1}}", "blessed {{FLAIR1}}", "dark {{FLAIR1}}",
            "closing {{FLAIR1}}", "conquered {{FLAIR1}}", "eternal {{FLAIR1}}", "timeless {{FLAIR1}}",
            "time-lost {{FLAIR1}}", "trembling {{FLAIR1}}", "unholy {{FLAIR1}}", "holy {{FLAIR1}}",
            "twilight's {{FLAIR1}}", "pride's {{FLAIR1}}", "traitor's {{FLAIR1}}", "hell's {{FLAIR1}}",
            "heaven's {{FLAIR1}}", "royal {{FLAIR1}}", "imperial {{FLAIR1}}",
            
            "wind{{FLAIR2}}", "storm{{FLAIR2}}", "day{{FLAIR2}}", "night{{FLAIR2}}", "moon{{FLAIR2}}",
            
            "the shifting {{FLAIR3}}", "twisting {{FLAIR3}}", "corrupted {{FLAIR3}}", "blighted {{FLAIR3}}",
            "the burning {{FLAIR3}}", "frozen {{FLAIR3}}", "radiant {{FLAIR3}}", "high {{FLAIR3}}", "searing {{FLAIR3}}",

            "the leviathan", "the light", "the lion", "the lone victor", "the lone wolf", "the king",
            "the gladiator", "the fallen", "the covanent", "the crown", "the damned",
        };

        public static string[] Flair1 = new string[] {
            "magic", "power", "fortune", "bones", "dreams", "eyes", "worlds",
            "delusions", "denial", "sorrow", "struggle", "games", "misery",
            "might", "nightmares", "grandeur"
        };

        public static string[] Flair2 = new string[] {
            "seeker", "walker", "treader", "wanderer", "dreams", "voices"
        };

        public static string[] Flair3 = new string[] {
            "sands", "worlds", "hells", "heavens"
        };

        public static string Get_Flair_Prefix()
        {
            if(Program.CoinFilp())
                return "of";
            return ", " + Program.GetRand(Flair_Prefix) + " of";
        }

        public static string Get_Flair()
        {
            var flair = Program.GetRand(Flair);
            flair = flair.Replace("{{FLAIR1}}", Program.GetRand(Flair1));
            flair = flair.Replace("{{FLAIR2}}", Program.GetRand(Flair2));
            flair = flair.Replace("{{FLAIR3}}", Program.GetRand(Flair3));
            return Get_Flair_Prefix() + " " + flair;
        }
    }
}