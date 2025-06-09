using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI statusText;
    [SerializeField] private Button backButton;

    private void Start()
    {
        backButton.onClick.AddListener(() => UIManager.Instance.OpenMainMenu());
    }

    public void SetCharacter(Character character)
    {
        statusText.text =
            $"ID: {character.ID}\n" +
            $"Level: {character.Level}\n" +
            $"Gold: {character.Gold}\n";
    }
}