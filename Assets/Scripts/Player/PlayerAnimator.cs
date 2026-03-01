using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private readonly int _speed = Animator.StringToHash(nameof(_speed));
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void ControlAnimation(float  speed)
    {
        _animator.SetFloat(_speed, Mathf.Abs(speed));
    }
}
