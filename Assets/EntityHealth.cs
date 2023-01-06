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
        _maxHealth += value;
    }

    public void UpdateCurrentHealth(int value)
    {
        CurrentHealth += value;
    }
}
