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
        // GameManager에서 Player의 인벤토리에서 아이템이 존재하는지 확인
        if (!GameManager.Instance.Player.Inventory.Contains(item))
        {
            Debug.Log("아이템이 인벤토리에 존재하지 않습니다.");
            return;  // 인벤토리에 아이템이 없으면 장착/해제 불가능
        }

        // equipIndicator가 활성화 되어있는지 확인
        if (equipIndicator.activeSelf == false)
        {
            Debug.Log("장착됨");
            equipIndicator.SetActive(true);

            GameManager.Instance.Player.EquipItem(item);  // 아이템 장착
        }
        else
        {
            equipIndicator.SetActive(false);
            GameManager.Instance.Player.UnequipItem(item);  // 아이템 해제
        }

        // 장착/해제 후 능력치 UI 업데이트
        GameManager.Instance.statusUI.UpdateStatusInfo(GameManager.Instance.Player);
    }
}


