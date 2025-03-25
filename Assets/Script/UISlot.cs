using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemIcon;
    public Item item = null;
    public GameObject equipIndicator; // "E" Ç¥½Ã

    private bool isEquipped = false;

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
        UpdateUi();
    }

    public void ToggleEquip()
    {
        isEquipped = !isEquipped;
        equipIndicator.SetActive(isEquipped);
    }

    public void UpdateUi()
    {
        equipIndicator.SetActive(isEquipped);
    }
}