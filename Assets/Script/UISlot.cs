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
        // �������� ������
        if (!GameManager.Instance.Player.Inventory.Contains(item))
        {
            Debug.Log("������ ����d");
            return; 
        }
        // ������ ���� �� ��ü
        if (equipIndicator.activeSelf == false) 
        {
            Debug.Log("������");
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
    //UI ������Ʈ
    public void UpdateUI()
    {
        itemIcon.sprite = item.itemIcon;
    }
}


