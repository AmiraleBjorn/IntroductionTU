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
    private void Update()
    {
        CachedMaxHealth = _playerHealth._maxHealth;
        UpdateSlider(_playerHealth.CurrentHealth);
    }
    void UpdateSlider(int newHealthValue)
    {
        _slider.value = newHealthValue;
/*        _text.text = $"{newHealthValue} / {CachedMaxHealth}";*/
        _text.text = newHealthValue + " / " + CachedMaxHealth;
    }

}
