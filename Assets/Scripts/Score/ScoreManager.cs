using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance
    {
        protected set;
        get;
    }

    public event Action<int> onScoreUpdated;

    private int score;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void Start()
    {
        ResetScore();
    }

    private void ResetScore()
    {
        score = 0;
        onScoreUpdated?.Invoke(score);
    }

    public void IncreaseScore()
    {
        score++;
        onScoreUpdated?.Invoke(score);
    }

    public int GetScore()
    {
        return score;
    }
}
