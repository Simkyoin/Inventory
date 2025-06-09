using UnityEngine;

private void SetData()
{
    Player = new Character("Spartan123", 5, 1000);

    // 아이템 데이터 생성 (아이콘은 Resources 폴더에 있어야 함)
    Sprite swordIcon = Resources.Load<Sprite>("Icons/sword_icon");
    Sprite swordIcon = Resources.Load<Sprite>("Icons/sword_icon");


    Player.AddItem(new Item("Iron Sword", swordIcon));
    Player.AddItem(new Item("Health Potion", potionIcon));

    UIManager.Instance.UIMainMenu.SetCharacter(Player);
    UIManager.Instance.UIStatus.SetCharacter(Player);
    UIManager.Instance.UIInventory.InitInventoryUI(Player.Inventory);
}