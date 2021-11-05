using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{

    private CharacterController _controller;
    private Transform _body;

    private Vector3 _targetVelocity;
    private Quaternion _targetRotation;
    private float _targetRotationSpeed;

    public void Move(Vector3 velocity)
    {
        _targetVelocity = velocity;
        
    }

    public void RotateTo(Quaternion rotation, float rotationSpeed)
    {
        _targetRotation = rotation;
        _targetRotationSpeed = rotationSpeed;
    }

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        _body = transform.Find("PlayerBody");
    }

    void Update()
    {
        _body.rotation = Quaternion.RotateTowards(_body.rotation, _targetRotation, _targetRotationSpeed);
    }

    void FixedUpdate()
    {
        _controller.Move(_targetVelocity);
    }
}           
