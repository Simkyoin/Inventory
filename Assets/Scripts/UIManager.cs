using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private GameObject uiMainMenu;
    [SerializeField] private GameObject uiStatus;
    [SerializeField] private GameObject uiInventory;

    public UIMainMenu UIMainMenu => uiMainMenu.GetComponent<UIMainMenu>();
    public UIStatus UIStatus => uiStatus.GetComponent<UIStatus>();
    public UIInventory UIInventory => uiInventory.GetComponent<UIInventory>();

    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void OpenMainMenu()
    {
        uiMainMenu.SetActive(true);
        uiStatus.SetActive(false);
        uiInventory.SetActive(false);
    }

    public void OpenStatus()
    {
        uiMainMenu.SetActive(false);
        uiStatus.SetActive(true);
        uiInventory.SetActive(false);
    }

    public void OpenInventory()
    {
        uiMainMenu.SetActive(false);
        uiStatus.SetActive(false);
        uiInventory.SetActive(true);
    }
}