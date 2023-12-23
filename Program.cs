using System;
using System.Collections.Generic;
using System.Linq;

public enum AttributeType
{
    Title,
    Rarity,
    Attribute,
    Type,
    Affix
}

public abstract class SwordElement
{
    public SwordElement parent { get; protected set; }
    public SwordElement child { get; protected set; }
    public AttributeType category { get; protected set; }
    public string text { get; protected set; }

    public SwordElement(AttributeType category, string text)
    {
        this.category = category;
        this.text = text;
    }

    public virtual SwordElement Add(SwordElement Element)
    {
        if(Element.category < category)
            SetParent(Element);
        else if(Element.category == category)
        {
            if(child != null)
                Element.child = child;
            child = Element;
        }
        else
            SetChild(Element);
        return this;
    }

    public void SetParent(SwordElement Element)
    {
        if(parent == null)
            parent = Element;
        else
            parent.Add(Element);
    }

    public void SetChild(SwordElement Element)
    {
        if(child == null)
            child = Element;
        else
            child.Add(Element);
    }

    public override string ToString() => text;

    public static implicit operator string(SwordElement l) => l.ToString();
}

public class SwordTitle : SwordElement
{
    public SwordTitle(string Title) : base(AttributeType.Title, Title) { }
}

public class SwordAttribute : SwordElement
{
    public SwordAttribute(string Attribute) : base(AttributeType.Attribute, Attribute) { }
}

public class SwordRarity : SwordElement
{
    public SwordRarity(string Rarity) : base(AttributeType.Rarity, Rarity) { }

    public override SwordElement Add(SwordElement Element)
    {
        if(Element.category < category)
        {
            SetParent(Element);
        }
        else if(Element.category == category)
        {
            text = Element.text;
        }
        else
            SetChild(Element);
        return this;
    }
}

public class SwordType : SwordElement
{
    public SwordType(string Item) : base(AttributeType.Type, Item) { }

    public override SwordElement Add(SwordElement Element)
    {
        if(Element.category < category)
        {
            SetParent(Element);
        }
        else if(Element.category == category)
        {
            text = Element.text;
        }
        else
        {
            SetChild(Element);
        }
        return this;
    }
}

public class SwordAffix : SwordElement
{
    public SwordAffix(string Affix) : base(AttributeType.Affix, Affix) { }
}

public class Sword
{
    protected List<SwordElement> Elements;

    public Sword() {
        Elements = new();
    }

    public Sword(List<SwordElement> elements) {
        Elements = new();
        foreach(var Element in elements)
            Add(Element);
    }

    public void Add (SwordElement element)
    {
        if(element.category == AttributeType.Rarity)
            Elements.RemoveAll(I => I.category == AttributeType.Rarity);
        if(element.category == AttributeType.Type)
            Elements.RemoveAll(I => I.category == AttributeType.Type);
        Elements.Add(element);
    }

    public string Build() =>
        string.Join(" ", Elements.OrderBy(I => I.category));
}

class Program
{
    static void Main()
    {
        // Build the sword
        Sword Sword = new(new(){
            new SwordTitle("Godreaper"),
            new SwordAttribute("Black"),
            new SwordAttribute("Adamantine"),
            new SwordAttribute("Hyperdeath"),
            new SwordAffix("of Heaven's Destruction"),
            new SwordType("Doomblade"),
            new SwordRarity("Mythical")
        });

        Console.WriteLine("Generated Sword Name:");
        Console.WriteLine(Sword.Build());
    }
}