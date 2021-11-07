using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{
    private CharacterController _controller;
    private Vector3 _targetVelocity;
    private Transform _body;
    private Quaternion _targetRotation;
    private float _targetRotationSpeed;

    
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _body = transform.Find("PlayerBody");
    }

    // Update is called once per frame
    void Update()
    {
        _controller.Move(_targetVelocity * Time.deltaTime);
        _body.rotation = Quaternion.RotateTowards(_body.rotation,  _targetRotation, _targetRotationSpeed);
    }

    public void Move(Vector3 velocity)
    {
        _targetVelocity = velocity;
    }


    public void RotateTo(Quaternion rotation, float rotationSpeed)
    {
        _targetRotation = rotation;
        _targetRotationSpeed = rotationSpeed;
    }
}
