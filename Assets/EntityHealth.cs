using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    [SerializeField] int _maxHealth;


    public int CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }


    public void UpdateMaxHealth(int value)
    {
        HealthUI healthUI = GetComponent<HealthUI>();
        CurrentHealth += value;
        _maxHealth += value;
        Debug.Log(healthUI);
        /*healthUI.UpdateSlider(CurrentHealth);*/
    }

    public void UpdateCurrentHealth(int value)
    {
        HealthUI healthUI = GetComponent<HealthUI>();
        CurrentHealth += value;
        Debug.Log(healthUI);
        /*healthUI.UpdateSlider(CurrentHealth);*/
    }
}
