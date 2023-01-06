using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{

    public int _maxHealth;

    public int CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = 50;
    }

    public void UpdateMaxHealth(int value)
    {
        CurrentHealth += value;
        _maxHealth += value;
    }

    public void UpdateCurrentHealth(int value)
    {
        if(CurrentHealth < _maxHealth)
        {
            CurrentHealth += value;
        }
        
    }
}
