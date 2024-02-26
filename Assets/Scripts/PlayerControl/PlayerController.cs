using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private FixedJoystick _fixedJoystick;

    [SerializeField] private float moveSpeed;

    private float _horizontal;
    private float _vertical;

    private void Update()
    {
        GetMovementInputs();
    }

    private void FixedUpdate()
    {
        SetMovement();
    }

    private void SetMovement()
    {
        playerRigidbody.velocity = GetNewVelocity();
    }

    private Vector3 GetNewVelocity()
    {
        return new Vector3(_horizontal, playerRigidbody.velocity.y, _vertical) * moveSpeed * Time.fixedDeltaTime;
    }
    
    private void GetMovementInputs()
    {
        _horizontal = _fixedJoystick.Horizontal;
        _vertical = _fixedJoystick.Vertical;
    }
}