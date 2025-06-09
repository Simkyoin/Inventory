using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI idText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI goldText;
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    private void Start()
    {
        statusButton.onClick.AddListener(() => UIManager.Instance.OpenStatus());
        inventoryButton.onClick.AddListener(() => UIManager.Instance.OpenInventory());
    }

    public void SetCharacter(Character character)
    {
        idText.text = $"ID: {character.ID}";
        levelText.text = $"Level: {character.Level}";
        goldText.text = $"Gold: {character.Gold}";
    }
}