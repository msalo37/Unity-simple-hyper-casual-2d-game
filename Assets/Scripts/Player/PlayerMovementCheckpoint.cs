using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerMovementCheckpoint : MonoBehaviour, IPlayerMovement
{
    [SerializeField] protected Transform[] checkPoints;
    [SerializeField] protected float speed;
    
    protected int _curIndex = 0;
    protected int _chOffset = 1;

    private Vector3 _checkpointPos;
    
    private void Start()
    {
        UpdateCheckpointPos();
    }

    public void Move(Transform player)
    {
        player.position = Vector3.MoveTowards(player.position, _checkpointPos, speed * Time.deltaTime);
        
        if (player.position == _checkpointPos)
            NextCheckpoint();
    }

    protected void NextCheckpoint()
    {
        _curIndex += _chOffset;

        if (_curIndex >= checkPoints.Length)
            _curIndex = 0;

        if (_curIndex < 0)
            _curIndex = checkPoints.Length - 1;
        
        UpdateCheckpointPos();
    }

    private void UpdateCheckpointPos()
    {
        _checkpointPos = checkPoints[_curIndex].position; 
    }
}
