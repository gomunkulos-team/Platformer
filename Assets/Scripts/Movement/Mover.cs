using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _jumpHight;
    [SerializeField] private float _moveSpeed;

    private Rigidbody2D _rigidbody;

    public float Speed { get; private set; }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        Speed = _rigidbody.linearVelocityX;
    }

    public void MoveOnX(float direction)
    {
        _rigidbody.linearVelocity= new Vector2( _moveSpeed * direction, _rigidbody.linearVelocity.y);
    }

    public void Jump()
    {
        _rigidbody.linearVelocityY = 0;
        _rigidbody.AddForce(Vector2.up * _jumpHight, ForceMode2D.Impulse);
    }
}