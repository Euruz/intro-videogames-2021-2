using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{
    private CharacterController _characterController;
    private Transform _body;

    private Vector3 _targetVelocity;
    private Vector3 _playerVelocity;
    private Quaternion _targetRotation;
    private float _targetRotationSpeed;
    private float _gravityValue = -9.81f;

    public void Move(Vector3 velocity)
    {
        _targetVelocity = velocity;
    }

    public void RotateTo(Quaternion rotation, float rotationSpeed)
    {
        _targetRotation = rotation;
        _targetRotationSpeed = rotationSpeed;
    }

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _body = transform.Find("PlayerBody");
    }

    void Update()
    {
        if (_characterController.isGrounded && _playerVelocity.y > 0)
        {
            _playerVelocity.y = 0f;
        }

        _characterController.Move(_targetVelocity * Time.deltaTime);

        _body.rotation = Quaternion.RotateTowards(_body.rotation, _targetRotation, _targetRotationSpeed);

        // ! El módulo character controller no tiene en cuenta la gravedad
        _playerVelocity.y += _gravityValue * Time.deltaTime;
        _characterController.Move(_playerVelocity * Time.deltaTime);
    }
}
