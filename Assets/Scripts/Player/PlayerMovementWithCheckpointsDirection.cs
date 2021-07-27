using System;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerMovementWithCheckpointsDirection : PlayerMovementCheckpoint, IPlayerTapAction
{
    public void DoAction(Transform player)
    {
        ChangeOffset();
    }

    private void ChangeOffset()
    {
        _chOffset = -_chOffset;
        NextCheckpoint();
    }
}
