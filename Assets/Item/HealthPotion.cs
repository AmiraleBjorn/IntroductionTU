using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Item
{

    [SerializeField] int _healthGain;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out EntityHealth health))
        {
            health.UpdateCurrentHealth(_healthGain);
            Destroy(gameObject);
        }
    }
}
