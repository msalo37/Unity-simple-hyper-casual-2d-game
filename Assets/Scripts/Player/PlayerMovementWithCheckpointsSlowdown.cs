using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementWithCheckpointsSlowdown : PlayerMovementCheckpoint, IPlayerHoldAction
{
    private float _defaultSpeed;

    [SerializeField] private float speedMultiplier;

    private void Start()
    {
        _defaultSpeed = speed;
    }
    
    private void RestoreSpeed()
    {
        speed = _defaultSpeed;
    }

    private void Slowdown()
    {
        speed *= speedMultiplier;
    }

    public void OnTapDown()
    {
        Slowdown();
    }

    public void OnTapUp()
    {
        RestoreSpeed();
    }
}
