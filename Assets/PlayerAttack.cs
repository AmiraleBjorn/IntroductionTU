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

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] InputActionReference _attack;

    public event Action OnStartAttack;
    public event Action OnStopAttack;

    [SerializeField] HitEntity _hitBox;
    [SerializeField] UnityEvent _onEvent;
    [SerializeField] UnityEvent _onEventPost;

    Coroutine AttackingRoutine { get; set; }
    private void Start()
    {
        _attack.action.started += StartAttack;
        _attack.action.canceled += StopAttack;
    }
    private void OnDestroy()
    {
        _attack.action.started -= StartAttack;
        _attack.action.canceled -= StopAttack;
    }
    IEnumerator AttackRoutine()
    {
        OnStartAttack?.Invoke();

        while (true)
        {
            yield return new WaitForFixedUpdate();
            if (_hitBox.touche == 1)
            {
                _hitBox.Attack();
            }
        }
    }
    private void StopAttack(InputAction.CallbackContext obj)
    {
        OnStopAttack?.Invoke();
        StopCoroutine(AttackRoutine());
    }

    private void StartAttack(InputAction.CallbackContext obj)
    {
        AttackingRoutine = StartCoroutine(AttackRoutine());
    }
}