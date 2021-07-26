using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Transform player;

        private IPlayerMovement _playerMovement;
        private IPlayerTapAction _playerTapAction;

        private void Start()
        {
            _playerMovement = GetComponent<IPlayerMovement>();
            _playerTapAction = GetComponent<IPlayerTapAction>();
        }

        private void Update()
        {
            _playerMovement.Move(player);

            if (Input.GetMouseButtonDown(0))
                _playerTapAction.DoAction(player);
        }
    }
}
