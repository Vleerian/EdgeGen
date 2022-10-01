using System;
using System.Globalization;
using System.Text.Encodings;

SwordComponent Blade = new SwordPartBase("Sword")
    .Decorate<SwordType>("Great")
    .Decorate<SwordModifier>("Hyperdeath")
    .Decorate<SwordModifier>("Rune-Forged")
    .Decorate<SwordTitle>("Espada")
    .Decorate<SwordModifier>("Thousandfold")
    .Decorate<SwordAffix>("of")
    .Decorate<SwordAffix>("Burning")
    .Decorate<SwordAffix>("Twilight");

Console.WriteLine(Blade.ToString());