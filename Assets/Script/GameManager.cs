using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } 

    public Character Player { get; private set; } 

    [SerializeField] private UIMainMenu mainMenuUI;
    [SerializeField] private UIStatus statusUI;

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

    private void Start()
    {
        SetData(); 
    }

    public void SetData()
    {
        Player = new Character("스파르타", 1, 100 , 35,40,35);

        mainMenuUI.UpdateCharacterInfo(Player);
        statusUI.UpdateStatusInfo(Player);
    }
}
