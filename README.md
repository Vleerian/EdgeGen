Generates random names in the vein of `Thunderfury, Blessed Blade of the Windseeker`

Example output:
```
chaos' sun devourer, antique katana of the crown
corruption's suncrackle, wicked deflector of the damned
abyssal nightsinger, demonic blade of the lone wolf
liar's infamy, skeletal reaver of dayvoices
interrogator, gleaming blade of stormwalker
hope's bite, improved eculptor of blighted heavens
darkfury, dancing longsword of heaven's delusions
ultimate despair, barbaric slicer of moonvoices
abyssal ghostblight, warworn katana of frozen heavens
destiny's oathkeeper, ghastly claymore of windtreader
```

Example usage:
```
static void Main(string[] args)
{
    string title = "";
    if(Sword_Gen.rand.Next(2) == 0)
        title += Sword_Gen.Get_Prefix() + " ";
    title += Sword_Gen.Get_Title();

    Console.WriteLine($"{title}, {Sword_Gen.Get_Description()} {Sword_Gen.Get_Type()} of {Sword_Gen.Get_Flair()}");
}
```