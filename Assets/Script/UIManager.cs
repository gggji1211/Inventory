using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }
    [SerializeField]
    private GameObject mainMenu;
    [SerializeField]
    private GameObject statusUI;
    [SerializeField]
    private GameObject inventoryUI;

    public GameObject MainMenu => mainMenu;
    public GameObject StatusUI => statusUI;
    public GameObject InventoryUI => inventoryUI;

  
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void OpenMainMenu()
    {
        mainMenu.gameObject.SetActive(true);
        statusUI.gameObject.SetActive(false);
        inventoryUI.gameObject.SetActive(false);
    }

    public void OpenStatus()
    {
        mainMenu.gameObject.SetActive(false);
        statusUI.gameObject.SetActive(true);
        inventoryUI.gameObject.SetActive(false);
    }

    public void OpenInventory()
    {
        mainMenu.gameObject.SetActive(false);
        statusUI.gameObject.SetActive(false);
        inventoryUI.gameObject.SetActive(true);
    }
}