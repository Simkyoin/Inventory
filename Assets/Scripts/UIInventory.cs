using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotParent;

    private List<UISlot> slots = new List<UISlot>();

    private void Start()
    {
        backButton.onClick.AddListener(() => UIManager.Instance.OpenMainMenu());
    }

    public void InitInventoryUI(List<Item> itemList)
    {
        foreach (Transform child in slotParent)
        {
            Destroy(child.gameObject); // 기존 슬롯 정리
        }

        slots.Clear();

        foreach (Item item in itemList)
        {
            GameObject slotObj = Instantiate(slotPrefab, slotParent);
            UISlot slot = slotObj.GetComponent<UISlot>();
            slot.SetItem(item);
            slots.Add(slot);
        }
    }

   
}