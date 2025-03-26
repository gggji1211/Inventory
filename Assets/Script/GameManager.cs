using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Character Player;

    [SerializeField] private UIInventory inventory;
    [SerializeField] private UIMainMenu mainMenuUI;
    [SerializeField] public UIStatus statusUI;

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
        //Sprite swordIcon = Resources.Load<Sprite>("Sprite/GUI_0");

        // Sprite shieldIcon = Resources.Load<Sprite>("Sprite/GUI_1");
        // Sprite bowIcon = Resources.Load<Sprite>("Sprite/GUI_2");

        Sprite[] sprite = Resources.LoadAll<Sprite>("Sprite/GUI");


        List<Item> allItems = new List<Item>
        {
            new Item("검", System.Array.Find(sprite,x => x.name == "GUI_0"),10,3),  // GUI 파일 가져오기 
            new Item("방패", System.Array.Find(sprite,x => x.name == "GUI_1"),3,10),
            new Item("활",  System.Array.Find(sprite,x => x.name == "GUI_2"),15,0)
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
