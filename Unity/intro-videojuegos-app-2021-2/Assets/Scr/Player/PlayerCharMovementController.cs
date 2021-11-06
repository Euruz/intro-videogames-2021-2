using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{
    private CharacterController playerController;
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
        /*_rb = GetComponent<Rigidbody>();*/
        _body = transform.Find("PlayerBody");
        playerController = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        _body.rotation = Quaternion.RotateTowards(_body.rotation, _targetRotation, _targetRotationSpeed);

        //Because move requires absolute 
        playerController.Move(_targetVelocity * Time.deltaTime);

    }
}
