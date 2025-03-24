using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour 
{
    [SerializeField]
    
     private Button statusButton;
     private Button inventoryButton;

    private void Start()
    {
        
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.OpenMainMenu();
    }

    public void OpenStatus()
    {
        UIManager.Instance.OpenStatus();
    }

    public void OpenInventory()
    {
        UIManager.Instance.OpenInventory();
    }
}
