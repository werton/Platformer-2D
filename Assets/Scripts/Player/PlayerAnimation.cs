using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;

    public void SetIdle()
    {
        _animator.SetBool("idle", true);
        _animator.SetBool("walking", false);
        _animator.SetBool("falling", false);
        _animator.SetBool("jumping", false);
    }

    public void SetWalk()
    {
        _animator.SetBool("walking", true);
        _animator.SetBool("idle", false);
        _animator.SetBool("falling", false);
        _animator.SetBool("jumping", false);
    }

    public void SetHurt()
    {
        _animator.SetBool("hurt", true);
    }

    public void SetFall()
    {
        _animator.SetBool("falling", true);
        _animator.SetBool("idle", false);
        _animator.SetBool("jumping", false);
    }

    public void SetJump()
    {
        _animator.SetBool("jumping", true);
        _animator.SetBool("falling", false);
        _animator.SetBool("idle", false);
        _animator.SetBool("walking", false);
    }

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
}