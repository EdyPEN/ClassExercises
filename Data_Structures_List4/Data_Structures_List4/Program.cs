
using System;
using System.Collections;
using System.Xml.Linq;

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


    public Item (string name, Type type, Rarity rarity, int numberSlots, bool uniqueUse)
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
    Hashtable inventory = new Hashtable();
    int slotsOccupied {  get; set; }
    int maximumSlots { get; set; }


    public Inventory(int slotsOccupied, int maximimSlots)
    {
        inventory = new Hashtable();
        this.slotsOccupied = slotsOccupied;
        this.maximumSlots = maximumSlots;
    }

    public bool InsertItem(Item item)
    {
        if (slotsOccupied + item.numberSlots > maximumSlots)
        {
            inventory.Add(item.name, item);
            slotsOccupied += item.numberSlots;
            return true;
        }
        else
            return false;
    }
    public Item RemoveItem(string name)
    {
        Item item = null;

        if (inventory.ContainsKey(name))
        {
            int count = (int)inventory[name];
            item = (Item)inventory[name];
            slotsOccupied -= item.numberSlots;
            inventory.Remove(name);

            if (count > 1)
            {
                inventory[name] = count - 1;
            }
            else
            {
                inventory.Remove(item);
            }
        }
        return item;
    }

    public int NumberOfItems()
    {
        return 0;
    }

    public int NumberOfSlots()
    {
        int occupiedSlots = 0;
        foreach (Item item in inventory)
        {
            occupiedSlots += item.numberSlots;
        }
        return occupiedSlots;
    }

    public void PrintItems()
    {
        foreach (Item item in inventory)
        {
            Console.WriteLine(item.name);
        }
    }

    public void CleanInventory()
    {
        inventory.Clear();
    }
    public void SaveInventory(string filename)
    {
        int counter = 1;
        string[] writeInFile = new string[NumberOfItems() + 1];
        writeInFile[0] = maximumSlots.ToString();

        foreach (Item item in inventory)
        {
            Console.WriteLine(item.ToString());
        }
    }
    public void LoadInventory(string filename)
    {

    }
}

partial class Program
{
    static void Main(string[] args)
    {
        Inventory inv = new Inventory(0, 20);
        Item item1 = new Item("Sword", Type.Weapon, Rarity.Common, 1, false);
        Item item2 = new Item("Poison", Type.Potion, Rarity.Epic, 1, false);
        Item item3 = new Item("Chestplate", Type.Weapon, Rarity.Rare, 1, false);
        Item item4 = new Item("Ice Sword", Type.Weapon, Rarity.Legendary, 1, false);
        Item item5 = new Item("Lore", Type.Scroll, Rarity.Rare, 1, false);

        inv.InsertItem(item1);
        inv.InsertItem(item2);
        inv.InsertItem(item3);
        inv.InsertItem(item4);
        inv.InsertItem(item5);

        inv.SaveInventory("SomeFile.txt");
    }
}