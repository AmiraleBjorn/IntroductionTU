using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEntity : MonoBehaviour
{
    public int touche { get; private set; }
    private EntityHealth entity;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<EntityHealth>())
        {
            collision.GetComponent<EntityHealth>().Hit();
        }
        else if (collision.GetComponentInParent<EntityHealth>())
        {
            collision.GetComponentInParent<EntityHealth>().Hit();
        }
    }
}