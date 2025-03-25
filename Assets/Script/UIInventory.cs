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
        //�÷��̾� ������ �߰��� �󽽷�ã�Ƽ� ������ �µ�����
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
        // 9���� ������ �̸� ����
        for (int i = 0; i < 9; i++)
        {
            GameObject newSlotObj = Instantiate(slotPrefab, slotParent);
            UISlot newSlot = newSlotObj.GetComponent<UISlot>();
            slots.Add(newSlot);
        }

  
    }


}
