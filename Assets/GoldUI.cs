using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] EntityGold _playerGold;

    int CachedMaxGold { get; set; }
    public void UpdateSlider(int newGoldValue)
    {
        _text.text = newGoldValue.ToString();
    }

    private void Update()
    {
        UpdateSlider(_playerGold.CurrentGold);
    }
}
