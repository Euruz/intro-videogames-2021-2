using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{
    private CharacterController _characterController;
    private Transform _body;
    
    private Vector3 _targetVelocity;
    private Quaternion _targetRotation;
    private float _targetRotationSpeed;
    private float gravity=-9.8f;

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
        _characterController = GetComponent<CharacterController>();
        _body = transform.Find("PlayerBody");
    }

    void Update()
    {
     _body.rotation = Quaternion.RotateTowards(_body.rotation,  _targetRotation, _targetRotationSpeed);
        _characterController.Move(_targetVelocity);
    }

    void FixedUpdate()
    {
        //adding gravity manually
        
        _targetVelocity.y=gravity*Time.deltaTime;
 

    }
}
