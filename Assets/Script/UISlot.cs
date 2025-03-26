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
        // GameManager���� Player�� �κ��丮���� �������� �����ϴ��� Ȯ��
        if (!GameManager.Instance.Player.Inventory.Contains(item))
        {
            Debug.Log("�������� �κ��丮�� �������� �ʽ��ϴ�.");
            return;  // �κ��丮�� �������� ������ ����/���� �Ұ���
        }

        // equipIndicator�� Ȱ��ȭ �Ǿ��ִ��� Ȯ��
        if (equipIndicator.activeSelf == false)
        {
            Debug.Log("������");
            equipIndicator.SetActive(true);

            GameManager.Instance.Player.EquipItem(item);  // ������ ����
        }
        else
        {
            equipIndicator.SetActive(false);
            GameManager.Instance.Player.UnequipItem(item);  // ������ ����
        }

        // ����/���� �� �ɷ�ġ UI ������Ʈ
        GameManager.Instance.statusUI.UpdateStatusInfo(GameManager.Instance.Player);
    }
}


