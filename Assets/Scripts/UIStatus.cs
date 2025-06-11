using TMPro;
using UnityEngine;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI idText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI goldText;
    [SerializeField] private TextMeshProUGUI equippedItemText;

    public void SetCharacter(Character character)
    {
        idText.text = $"ID: {character.ID}";
        levelText.text = $"Level: {character.Level}";
        goldText.text = $"Gold: {character.Gold}";

        // 추가: 장착 아이템 표시
        if (character.EquippedItem != null)
        {
            equippedItemText.text = $"Equipped: {character.EquippedItem.Name}";
        }
        else
        {
            equippedItemText.text = "Equipped: None";
        }
    }
}