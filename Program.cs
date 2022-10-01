using System;
using System.Globalization;
using System.Text.Encodings;

SwordComponent Blade = new Sword("Blade")
    .Decorate<SwordModifier>("Blessed")
    .Decorate<SwordTitle>("ThunderFury")
    .Decorate<SwordAffix>("of the Windseeker");

Console.WriteLine(Blade.ToString());