using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private InputReader _inputReader;
    private Mover _mover;
    private Rotator _rotator;
    private PlayerAnimator _animator;
    private TriggerCollector _triggerCollector;

    public event Action<Coin> CoinCollected;

    private void Awake()
    {
        _inputReader = GetComponent<InputReader>();
        _mover = GetComponent<Mover>();
        _rotator = GetComponent<Rotator>();
        _animator = GetComponent<PlayerAnimator>();
        _triggerCollector = GetComponent<TriggerCollector>();
    }

    private void OnEnable()
    {
        _triggerCollector.CoinTouched += CollectCoin;
    }

    private void OnDisable()
    {
        _triggerCollector.CoinTouched -= CollectCoin;
    }

    private void FixedUpdate()
    {
        if (_inputReader.DirectionX != 0)
        {
            _rotator.Rotate(_inputReader.DirectionX);
            _animator.ControlAnimation(_inputReader.DirectionX);
            _mover.MoveOnX(_inputReader.DirectionX);
        }

        if (_inputReader.GetIsJump())
            _mover.Jump();
    }

    private void CollectCoin(Coin coin)
    {
        CoinCollected?.Invoke(coin);
    }
}
