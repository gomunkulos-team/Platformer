using System;
using UnityEngine;

public class TriggerCollector : MonoBehaviour
{
    public event Action<Coin> CoinTouched;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Coin coin))
            CoinTouched?.Invoke(coin);
    }
}
