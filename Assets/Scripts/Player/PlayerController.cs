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
        private IPlayerHoldAction _playerHoldAction;

        private void Start()
        {
            _playerMovement = GetComponent<IPlayerMovement>();
            _playerTapAction = GetComponent<IPlayerTapAction>();
            _playerHoldAction = GetComponent<IPlayerHoldAction>();
        }

        private void Update()
        {
            if (_playerMovement != null)
                _playerMovement.Move(player);

            if (Input.GetMouseButtonDown(0))
            {
                if (_playerTapAction != null)
                    _playerTapAction.DoAction(player);
                
                if (_playerHoldAction != null)
                    _playerHoldAction.ClickDown();
            }

            if (Input.GetMouseButtonUp(0))
                if (_playerHoldAction != null)
                    _playerHoldAction.ClickUp();
        }
    }
}
