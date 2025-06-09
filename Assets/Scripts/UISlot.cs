using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEditor.Progress;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemImage;
    [SerializeField] private TextMeshProUGUI itemNameText;

    private Item item;

    public void SetItem(Item newItem)
    {
        item = newItem;
        RefreshUI();
    }

    private void RefreshUI()
    {
        itemNameText.text = item.Name;
        itemImage.sprite = item.Icon;
    }
}