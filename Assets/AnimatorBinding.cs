using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorBinding : MonoBehaviour
{
    [SerializeField] PlayerMove _playerMove;
    [SerializeField] Animator _animator;
    public void Start()
    {
        _playerMove.OnStartMove += SetMove;
        _playerMove.OnStopMove += SetIdle;
    }
    public void SetMove()
    {
        _animator.SetBool("Walking", true);
    }
    public void SetIdle()
    {
        _animator.SetBool("Walking", false);
    }
}
