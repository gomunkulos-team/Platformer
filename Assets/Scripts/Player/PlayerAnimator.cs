using UnityEngine;
using UnityEngine.UIElements;

public class PlayerAnimator : MonoBehaviour
{
    private Animator _animator;
    private readonly int Speed = Animator.StringToHash(nameof(Speed));

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void ControlAnimation(float  speed)
    {
        _animator.SetFloat(Speed, Mathf.Abs(speed));
    }
}
