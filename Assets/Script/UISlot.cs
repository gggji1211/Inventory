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
            itemIcon.sprite = item.itemIcon;
            itemIcon.gameObject.SetActive(true);
        }
        else
        {
            itemIcon.gameObject.SetActive(false);
        }
    }

    public void ToggleEquip()
    {
        if (GameManager.Instance.Player.Inventory.Count == 0 || item == null)
        {
            Debug.Log("아이템이 없습니다.");
            return; 
        }

        if (equipIndicator.activeSelf == false)
        {
            Debug.Log("장착됨");
            equipIndicator.SetActive(true);

            Player.EquipItem(item);  
        }
        else
        {
            equipIndicator.SetActive(false);
            Player.UnequipItem(item);  
        }
    }

}
