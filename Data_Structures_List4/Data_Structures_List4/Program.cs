using System;
using System.Collections;
using System.IO;


public enum Type
{
    Weapon,
    Armor,
    Potion,
    Scroll
}

public enum Rarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary
}

public class Item
{
    public string name { get; set; }
    public Type type { get; set; }
    public Rarity rarity { get; set; }
    public int numberSlots { get; set; }
    public bool uniqueUse { get; set; }

    public Item(string name, Type type, Rarity rarity, int numberSlots, bool uniqueUse)
    {
        this.name = name;
        this.type = type;
        this.rarity = rarity;
        this.numberSlots = numberSlots;
        this.uniqueUse = uniqueUse;
    }

}

public class Inventory
{

}

partial class Program
{
    static void Main(string[] args)
    {

    }
}
