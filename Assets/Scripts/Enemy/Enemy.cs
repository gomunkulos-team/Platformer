using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Patroller _patroller;
    private Mover _mover;
    private Rotator _rotator;

    private float _flipRotation = -1;

    private void Awake()
    {
        _patroller = GetComponent<Patroller>();
        _mover = GetComponent<Mover>();
        _rotator = GetComponent<Rotator>();
    }

    private void FixedUpdate()
    {
        _rotator.Rotate(_patroller.Direction * _flipRotation);
        _mover.MoveOnX(_patroller.Direction);
    }
}
