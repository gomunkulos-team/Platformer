using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _jumpHight;

    [SerializeField] private float _moveSpeed;

    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Vector3 inputVector = new Vector3(0, 0, 0);


        if (Input.GetKeyDown(KeyCode.Space))
            _rigidbody.linearVelocity = new Vector2(_rigidbody.linearVelocity.x, _jumpHight);

        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
            _spriteRenderer.flipX = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = +1;
            _spriteRenderer.flipX = false;
        }

        float positionX = inputVector.x * _moveSpeed * Time.deltaTime;

        _animator.SetFloat("Speed", Mathf.Abs( positionX));

        inputVector.Set(positionX, 0, 0);

        transform.position += inputVector;
    }
}
