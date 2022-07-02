using System;
using System.Globalization;
using System.Text.Encodings;

using EdgeGen;

Console.WriteLine(new Sword() {
    Prefix = new Prefix("ThunderFury,") {
    }.Chain(new Prefix("Blessed")),
    Type = new SwordType("Blade"),
    Affix = new Afffix("of the Windseeker")
});