using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Item
{

    [SerializeField] int _healthBonus;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out EntityHealth health))
        {
            health.UpdateMaxHealth(_healthBonus);
        }

    }
}
