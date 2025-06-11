using System.Collections.Generic;

public class Character
{
    public string ID { get; private set; }
    public int Level { get; private set; }
    public int Gold { get; private set; }

    public List<Item> Inventory { get; private set; }
    public Item EquippedItem { get; private set; } // 현재 장착 아이템 1개

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

    public void Equip(Item item)
    {
        if (EquippedItem == item)
            EquippedItem = null; // 해제
        else
            EquippedItem = item; // 장착
    }

    public bool IsEquipped(Item item)
    {
        return EquippedItem == item;
    }
}