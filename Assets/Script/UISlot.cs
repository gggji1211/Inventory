using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemIcon;
    public Item item = null;

     public void UpdateUi()
     {

     }
    public void SetItem(Item item)
    {
      this.item = item;
        if (item != null)
        {
            itemIcon.gameObject.SetActive(true);

        }
        else
        {
            itemIcon.gameObject.SetActive(false);

            itemIcon.sprite = item.itemIcon;
        }
        UpdateUi();
    }
}

