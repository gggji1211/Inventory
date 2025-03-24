using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour 
{
    [SerializeField] private GameObject slotPrefab;  
    [SerializeField] private Transform slotParent; 
    [SerializeField] private int slotCount = 9; 

    private List<UISlot> slots = new List<UISlot>();

    private void Start()
    {
        InitInventoryUI();
    }

    private void InitInventoryUI()
    {
        for (int i = 0; i < slotCount; i++)
        {
            GameObject newSlotObj = Instantiate(slotPrefab, slotParent);
            UISlot newSlot = newSlotObj.GetComponent<UISlot>(); 
                slots.Add(newSlot);
        }
    }
}
