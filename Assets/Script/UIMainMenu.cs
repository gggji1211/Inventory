using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;

    // 캐릭터 정보를 UI에 반영하는 메서드
    public void UpdateCharacterInfo(Character player)
    {
        
        nameText.text = $"이름: {player.Name}";
        levelText.text = $"레벨: {player.Level}";
    }
}
