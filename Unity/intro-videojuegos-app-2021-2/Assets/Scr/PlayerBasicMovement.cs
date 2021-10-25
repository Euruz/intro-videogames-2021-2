using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasicMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField]
    private float _maxSpeed = 5f;
    [SerializeField]
    private float _acceleration = 15f;
    [SerializeField]
    private float _deceleration = 15f;
    [SerializeField]
    private float _dashSpeed = 50f;
    [SerializeField]
    private float _dashTime = 5f;
    
    private float _currentSpeed = 0.1f;
    private float _dashingTimer = 0.5f;
    private bool _dashing = false;
    private Vector3 lastMovementDirection;
    
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _dashing = true;
        }
        float speed = _dashing ? _dashSpeed : _currentSpeed;
        Vector3 input = new Vector3(horizontal, 0, vertical);
        if (input.magnitude > 0)
        {
            _currentSpeed += _acceleration * Time.deltaTime;
            lastMovementDirection = input;
        }
        else
        {
            _currentSpeed -= _deceleration * Time.deltaTime;
        }
        _currentSpeed = Mathf.Clamp(_currentSpeed, 0f, _maxSpeed);
        Vector3 velocity = lastMovementDirection * speed;
        Vector3 movement = velocity * Time.deltaTime;
        transform.position += movement;
    }

    private void FixedUpdate()
    {
        if (_dashing && _dashingTimer < _dashTime)
        {
            _dashingTimer += 0.1f;
        }
        else
        {
            _dashingTimer = 0f;
            _dashing = false;
        }
    }
}
