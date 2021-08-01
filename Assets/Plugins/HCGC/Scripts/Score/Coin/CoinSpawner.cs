using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    private GameObject _currentCoin;

    private ISpawner _spawner;

    private void Awake()
    {
        _spawner = GetComponent<ISpawner>();
    }

    private void Update()
    {
        if (_currentCoin == null)
            _currentCoin = _spawner.Create();
    }
}
