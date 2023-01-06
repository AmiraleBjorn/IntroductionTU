using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Item
{

    [SerializeField] int _goldGain;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out EntityGold gold))
        {
            gold.UpdateCurrentGold(_goldGain);
        }

    }
}
