using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityGold : MonoBehaviour
{

    [SerializeField] int _baseGold;
    public int CurrentGold { get; private set; }

    public void UpdateCurrentGold(int value)
    {
        CurrentGold += value;
    }
}
