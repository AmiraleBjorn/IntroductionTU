using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    [SerializeField] Slider _slider;
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] EntityHealth _playerHealth;

    int CachedMaxHealth { get; set; }


    public void UpdateSlider(int newHealthValue)
    {
        _slider.value = newHealthValue;
        _text.text = $"{newHealthValue} / {CachedMaxHealth}";
    }

    public void UpdateSliderMaxHealth(int newMaxHealthValue)
    {
        _slider.maxValue = newMaxHealthValue;
        _text.text = $"{_playerHealth.CurrentHealth} / {newMaxHealthValue}";
        CachedMaxHealth = newMaxHealthValue;
    }

    private void Update()
    {
        UpdateSlider(_playerHealth.CurrentHealth);
        UpdateSliderMaxHealth(_playerHealth._maxHealth);
    }

}
