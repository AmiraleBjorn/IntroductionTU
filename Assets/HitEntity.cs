using Cinemachine;
using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class HitEntity : MonoBehaviour
{
    [SerializeField] InputActionReference _hit;

    private EntityHealth entity;
    public event Action OnStartHit;
    public event Action OnStopHit;

    private void Start()
    {
        _hit.action.started += StartHit;
        _hit.action.canceled += StopHit;
    }
    private void OnDestroy()
    {
        _hit.action.started -= StartHit;
        _hit.action.canceled -= StopHit;
    }
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
    private void StartHit(InputAction.CallbackContext obj)
    {
        OnStartHit?.Invoke();
    }
    private void StopHit(InputAction.CallbackContext obj)
    {
        OnStopHit?.Invoke();
    }
}