using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemImage;
    [SerializeField] private TextMeshProUGUI itemNameText;
    [SerializeField] private Image highlightImage; // 강조용 이미지 (테두리 등)

    private Item item;


    
    public void SetItem(Item newItem)
    {
        item = newItem;
        RefreshUI();
    }
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }
    public void RefreshUI()
    {
        itemNameText.text = item.Name;
        itemImage.sprite = item.Icon;

        // 장착 여부에 따라 테두리 표시
        highlightImage.enabled = GameManager.Instance.Player.IsEquipped(item);
    }

    public void OnClick()
    {
        GameManager.Instance.Player.Equip(item);

        // 인벤토리 전체 새로고침
        UIManager.Instance.UIInventory.RefreshInventoryUI();
        UIManager.Instance.UIStatus.SetCharacter(GameManager.Instance.Player); // 상태창 갱신
    }
}