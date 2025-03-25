using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotParent;

    private List<UISlot> slots = new List<UISlot>();
    public void Additem(Item item)

    {
        //플레이어 아이템 추가시 빈슬롯찾아서 아이템 셋데이터
        Debug.Log(slots.Count);
        Debug.Log("Additem");
        for (int i = 0; i < slots.Count; i++)
        {
            if (string.IsNullOrEmpty( slots[i].item.itemName ) )
            {
                slots[i].SetItem(item);
                Debug.Log(item.itemName);
                return;
            }
        }
    }

    private void Awake()
    {
        InitInventoryUI();
        //gameObject.SetActive(false);
    }

    private void InitInventoryUI()
    {
        // 9개의 슬롯을 미리 생성
        for (int i = 0; i < 9; i++)
        {
            GameObject newSlotObj = Instantiate(slotPrefab, slotParent);
            UISlot newSlot = newSlotObj.GetComponent<UISlot>();
            slots.Add(newSlot);
        }

  
    }


}
