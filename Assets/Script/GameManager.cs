using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Player = new Character("���ĸ�Ÿ", 1, 100, 35, 40, 35); 
        SetData();
    }

    public void SetData()
    {
        Sprite swordIcon = Resources.Load<Sprite>("Sprite/GUI/GUI_0");
        if (swordIcon == null) Debug.LogError("swordIcon �ε� ����!");

        Sprite shieldIcon = Resources.Load<Sprite>("Sprite/GUI/GUI_1");
        if (shieldIcon == null) Debug.LogError("shieldIcon �ε� ����!");

        Sprite bowIcon = Resources.Load<Sprite>("Sprite/GUI/GUI_2");
        if (bowIcon == null) Debug.LogError("bowIcon �ε� ����!");



        List<Item> allItems = new List<Item>
        {
            new Item("��", swordIcon,10,3),
            new Item("����", shieldIcon,3,10),
            new Item("Ȱ", bowIcon,15,0)
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
