using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemIcon;  // ������ �̹���
    [SerializeField] private TextMeshProUGUI itemCountText; // ������ ����

    public void SetItem(Sprite icon, int count)
    {
        itemIcon.sprite = icon;
        itemCountText.text = count > 1 ? count.ToString() : "";
        RefreshUI(true);
    }

    public void RefreshUI(bool isActive)
    {
        itemIcon.gameObject.SetActive(isActive);
        itemCountText.gameObject.SetActive(isActive);
    }
}
