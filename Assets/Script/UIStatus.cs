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


    // 캐릭터 정보를 UI에 반영하는 메서드
    public void UpdateStatusInfo(Character player)
    {
        healthText.text = $"{player.Health}";
        attackText.text = $"{player.AttackPower}";
        defenseText.text = $"{player.Defense}";
        critical.text = $"{player.Critical}";


    }
}
