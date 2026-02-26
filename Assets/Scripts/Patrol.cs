using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] Transform[] _waypoints;
    [SerializeField] float _speed;

    private int _currentWaypoint = 0;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Mathf.Abs(transform.position.x - _waypoints[_currentWaypoint].position.x) < 0.1f)
            _currentWaypoint = (_currentWaypoint + 1) % _waypoints.Length;

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoint].position, _speed * Time.deltaTime);

        if(_waypoints[_currentWaypoint].position.x > transform.position.x)
            _spriteRenderer.flipX = false;
        else
            _spriteRenderer.flipX = true;
    }
}
