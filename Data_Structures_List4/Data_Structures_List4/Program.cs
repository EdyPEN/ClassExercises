using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography.X509Certificates;


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
    Hashtable itemHashtable = new Hashtable();
    private int inventorySlots = 9;
    private int occupiedInventorySlots = 0;

    bool Insert(Item item)
    {

        if (itemHashtable.ContainsKey(item.name))
        {
            return false;
        }
        if (item.numberSlots <= (inventorySlots - occupiedInventorySlots))
        {
            occupiedInventorySlots += item.numberSlots;
            itemHashtable.Add(item.name, item);
            return true;
        }
        else
            return false;
    }

    Item Remove(string name)
    {
        if (itemHashtable.ContainsKey(name))
        {
            itemHashtable.Remove(name);
            occupiedInventorySlots -= ((Item)itemHashtable[name]).numberSlots;
            return (Item)itemHashtable[name];
        }
        else
        {
            return null;
        }
    }

    int NumberItems()
    {
        return itemHashtable.Count;
    }

    int NumberSlots()
    {
        return occupiedInventorySlots;
    }

    void PrintItems(string name)
    {
        foreach (Item item in itemHashtable.Values)
        {
            Console.WriteLine(item.name);
        }
    }

    void Clean()
    {
        itemHashtable.Clear();
    }

    void Save(string filename)
    {
        List<string> inventoryInfo = new List<string>();

        inventoryInfo.Add(inventorySlots.ToString());

        foreach (Item item in itemHashtable.Values)
        {
            inventoryInfo.Add($"{item.name}, {item.type}, {item.rarity}, {item.numberSlots}, {item.uniqueUse}");
        }

        File.WriteAllLines(filename, inventoryInfo);

    }
    void Load(string filename)
{
    string[] inventoryInfo = File.ReadAllLines(filename);

    inventorySlots = int.Parse(inventoryInfo[0]);

    itemHashtable.Clear();
    occupiedInventorySlots = 0;

    for (int i = 1; i < inventoryInfo.Length; i++)
    {
            //Idk how to do this part ;-;
    }
}

}

partial class Program
{
    static void Main(string[] args)
    {

    }
}
