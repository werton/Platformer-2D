using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Chest : TouchableSpawner
{
    private const string OpenAnimation = "open";

    [SerializeField] private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();

        Body.Touched += PlayAnimation;
    }

    private void PlayAnimation()
    {
        _animator.SetTrigger(OpenAnimation);
    }

    private void OnDestroy()
    {
        Body.Touched -= PlayAnimation;
    }
}