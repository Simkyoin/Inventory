using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Character Player { get; private set; }

    private void Start()
    {
        SetData(); // 이제 UIManager.Instance는 절대 null 아님
    }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    private void SetData()
    {
        Player = new Character("Spartan123", 5, 1000);

        // 아이템 데이터 생성
        Sprite swordIcon = Resources.Load<Sprite>("Icons/weapon_lavish_sword");
        Sprite potionIcon = Resources.Load<Sprite>("Icons/ui_heart_full");
        Sprite bowIcon = Resources.Load<Sprite>("Icons/weapon_bow");
        Sprite axeIcon = Resources.Load<Sprite>("Icons/weapon_axe");

        Player.AddItem(new Item("Iavish Sword", swordIcon));
        Player.AddItem(new Item("Health Potion", potionIcon));
        Player.AddItem(new Item("Bow", bowIcon));
        Player.AddItem(new Item("Axe", axeIcon));

        UIManager.Instance.UIMainMenu.SetCharacter(Player);
        UIManager.Instance.UIStatus.SetCharacter(Player);
        UIManager.Instance.UIInventory.InitInventoryUI(Player.Inventory);
    }
}