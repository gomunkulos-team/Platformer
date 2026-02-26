using System.Collections;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    [SerializeField] Coin _coinPrefab;

    private float _timeForEnableCoin = 3;

    private void OnEnable()
    {
        _coinPrefab.OnCoinCollected += SwitchStates;
    }

    private void OnDisable()
    {
        _coinPrefab.OnCoinCollected -= SwitchStates;
    }

    private void SwitchStates(Coin coin)
    {
        coin.gameObject.SetActive(false);
        StartCoroutine(WaitTime(coin));
    }

    private IEnumerator WaitTime(Coin coin)
    {
        yield return new WaitForSecondsRealtime(_timeForEnableCoin);
        coin.gameObject.SetActive(true);
    }
}


