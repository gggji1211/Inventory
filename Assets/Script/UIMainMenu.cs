using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{



    

    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;

    // ĳ���� ������ UI�� �ݿ��ϴ� �޼���
    public void UpdateCharacterInfo(Character player)
    {
        
        nameText.text = $"�̸�: {player.Name}";
        levelText.text = $"����: {player.Level}";
    }
}
