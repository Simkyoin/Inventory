using System.Collections.Generic;

public class Character
{
    public string ID { get; private set; }
    public int Level { get; private set; }
    public int Gold { get; private set; }

    public List<Item> Inventory { get; private set; }

    public Character(string id, int level, int gold)
    {
        ID = id;
        Level = level;
        Gold = gold;
        Inventory = new List<Item>();
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }
}