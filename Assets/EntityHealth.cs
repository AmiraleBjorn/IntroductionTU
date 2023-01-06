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


    public void Hit()
    {
        _maxHealth += value;
    }

    public void Death()
    {
        CurrentHealth += value;
    }
}