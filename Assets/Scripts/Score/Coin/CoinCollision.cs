using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (ScoreManager.Instance != null) ScoreManager.Instance.IncreaseScore();
            transform.DOScale(new Vector3(0, 0, 0), 0.2f).OnComplete(delegate
            {
                transform.DOKill();
                Destroy(gameObject);
            });
        }
    }
}
