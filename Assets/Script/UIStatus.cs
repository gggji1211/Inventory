using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI attackText;
    [SerializeField] private TextMeshProUGUI defenseText;
    [SerializeField] private TextMeshProUGUI critical;


    // ĳ���� ������ UI�� �ݿ��ϴ� �޼���
    public void UpdateStatusInfo(Character player)
    {
        healthText.text = $"{player.Health}";
        attackText.text = $"{player.AttackPower}";
        defenseText.text = $"{player.Defense}";
        critical.text = $"{player.Critical}";


    }
}
