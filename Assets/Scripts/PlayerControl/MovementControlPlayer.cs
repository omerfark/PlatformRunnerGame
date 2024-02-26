using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControlPlayer : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private FixedJoystick fixedJoystick;
    [SerializeField] private float moveSpeed;

    private float _horizontal;
    private float _vertical;

    private void Update()
    {
        GetMovement();
    }

    private void FixedUpdate()
    {
        SetMovement();
    }

    private void SetMovement()
    {
        var movement = new Vector3(_horizontal, 0, _vertical);
        movement.Normalize();
        transform.Translate(movement * (moveSpeed * Time.deltaTime), Space.World);
    }

    private void GetMovement()
    {
        _horizontal = -fixedJoystick.Vertical;
        _vertical = fixedJoystick.Horizontal;
    }
    
    public Transform startingPosition;

    public void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision trigger");
        if (collision.gameObject.CompareTag("Obstacle"))
            player.transform.position = startingPosition.position;

    }
}