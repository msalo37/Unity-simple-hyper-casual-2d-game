using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ScoreToText : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [Space]
    [SerializeField] private Vector3 animationScale = new Vector3(1.1f, 1.1f, 1.1f);
    [SerializeField] private float animationSeconds = 0.2f;
    
    private void Awake()
    {
        if (scoreText == null)
            scoreText = GetComponent<Text>();
    }

    private void OnEnable()
    {
        ScoreManager.Instance.onScoreUpdated += UpdateText;
    }

    private void OnDisable()
    {
        ScoreManager.Instance.onScoreUpdated -= UpdateText;
    }

    private void UpdateText(int score)
    {
        if (scoreText == null)
        {
            Debug.LogWarning("Score text is null!");
            return;
        }
        
        scoreText.text = score.ToString();

        if (animationScale != Vector3.one)
            scoreText.transform.DOScale(animationScale, animationSeconds).OnComplete(delegate
            {
                scoreText.transform.DOScale(Vector3.one, animationSeconds);
            });
    }
}
