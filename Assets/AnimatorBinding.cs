using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorBinding : MonoBehaviour
{
    [SerializeField] PlayerMove _playerMove;
    [SerializeField] PlayerAttack _playerAttack;
    [SerializeField] HitEntity _hitEntity;
    [SerializeField] Animator _animator;
    public void Start()
    {
        _playerMove.OnStartMove += SetMove;
        _playerMove.OnStopMove += SetIdle;
        _playerAttack.OnStartAttack += SetAttack;
        _playerAttack.OnStopAttack += SetIdle;
        _hitEntity.OnStartHit += SetHit;
        _hitEntity.OnStopHit += SetIdle;
    }
    public void SetMove()
    {
        _animator.SetBool("Walking", true);
    }
    public void SetIdle()
    {
        _animator.SetBool("Walking", false);
    }
    public void SetAttack()
    {
        _animator.SetTrigger("Attack");
    }
    public void SetHit()
    {
        _animator.SetTrigger("Hit");
    }
}
