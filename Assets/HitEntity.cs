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
            entity = collision.GetComponent<EntityHealth>();
            touche += 1;
        }
    }

    public void Attack()
    {
        touche = 0;
        entity.Hit();
    }
}