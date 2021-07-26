using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Echo2DEffect : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private float spawnTime, destroyTime;

    private void Start()
    {
        StartCoroutine(EchoEffect());
    }

    private IEnumerator EchoEffect()
    {
        while(true)
        {
            Transform tr = Instantiate(prefab, transform.position, transform.rotation).transform;
            tr.DOScale(new Vector3(0, 0, 0), destroyTime).OnComplete(delegate { Destroy(tr.gameObject); });
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
