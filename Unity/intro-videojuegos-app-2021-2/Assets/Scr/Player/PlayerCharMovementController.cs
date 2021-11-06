using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : PlayerMovement
{
    private CharacterController _characterController;
    public override void Move(Vector3 velocity)
    {
        //If is not touching the ground, add a vertical velocity to make it fall.
        if (_characterController.isGrounded == false)
        {
            velocity.y = -9.8f;
        }
        
        _targetVelocity = velocity * Time.deltaTime;
        _characterController.Move(_targetVelocity);
        
    }

    public override void RotateTo(Quaternion rotation, float rotationSpeed)
    {
        _targetRotation = rotation;
        _targetRotationSpeed = rotationSpeed;
       // _characterController.
    }

    protected override void Start()
    {
        base.Start();
        _characterController = GetComponent<CharacterController>();
        
    }

}
