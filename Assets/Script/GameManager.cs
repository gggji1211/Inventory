using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Character Player;

    [SerializeField] private UIInventory inventory;
    [SerializeField] private UIMainMenu mainMenuUI;
    [SerializeField] private UIStatus statusUI;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }


    private void Start()
    {
        Player = new Character("스파르타", 1, 100, 35, 40, 35); 
        SetData();
    }

    public void SetData()
    {
        Sprite swordIcon = Resources.Load<Sprite>("Sprite/GUI/GUI_0");
        Sprite shieldIcon = Resources.Load<Sprite>("Sprite/GUI/GUI_1");
        Sprite bowIcon = Resources.Load<Sprite>("Sprite/GUI/GUI_2");



        List<Item> allItems = new List<Item>
        {
            new Item("검", swordIcon,10,3),
            new Item("방패", shieldIcon,3,10),
            new Item("활", bowIcon,15,0)
        };

        foreach (var item in allItems)
        {
           Player.AddItem(item);
           inventory.Additem(item);
        }

        mainMenuUI?.UpdateCharacterInfo(Player);
        Debug.Log(Player.Inventory[0].itemName);
        statusUI?.UpdateStatusInfo(Player);
    }

    public Character GetPlayer()
    {
        return Player;
    }
}
