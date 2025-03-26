using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemIcon;
    public Item item = null;
    public GameObject equipIndicator;

    public Character Player;



    public void SetItem(Item newItem)
    {
        item = newItem;
        if (item != null)
        {
            itemIcon.gameObject.SetActive(true);
        }
        else
        {
            itemIcon.gameObject.SetActive(false);
        }
        UpdateUI();
    }

    public void ToggleEquip()
    {
        // 아이템이 없을시
        if (!GameManager.Instance.Player.Inventory.Contains(item))
        {
            Debug.Log("아이템 없음d");
            return; 
        }
        // 아이템 장착 및 해체
        if (equipIndicator.activeSelf == false) 
        {
            Debug.Log("장착됨");
            equipIndicator.SetActive(true);

            GameManager.Instance.Player.EquipItem(item);  
        }
        else
        {
            equipIndicator.SetActive(false);
            GameManager.Instance.Player.UnequipItem(item);  
        }

        GameManager.Instance.statusUI.UpdateStatusInfo(GameManager.Instance.Player);
    }
    //UI 업데이트
    public void UpdateUI()
    {
        itemIcon.sprite = item.itemIcon;
    }
}


