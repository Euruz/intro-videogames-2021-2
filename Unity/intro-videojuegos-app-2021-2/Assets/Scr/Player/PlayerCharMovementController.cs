using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MovementController;

public class PlayerCharMovementController : MonoBehaviour, IMovementController
{
    private CharacterController _controller;
    private Transform _body;
    private Vector3 _velocity;
    private Quaternion _rotation;
    private float _rotationSpeed;
    private float _GravityValue = -9.81f;
    public void Move(Vector3 velocity) {
        _velocity = velocity;
    }

    public void RotateTo(Quaternion rotation, float rotationSpeed) {
        _rotation = rotation;
        _rotationSpeed = rotationSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _body = transform.Find("PlayerBody");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_body.position.y == 1 && _velocity.y < 0) {
            _velocity.y = 0f;
        } else {
            _velocity.y += _body.position.y * _GravityValue;
        }

        _controller.Move(_velocity * Time.deltaTime);
        _body.rotation = Quaternion.RotateTowards(_body.rotation,  _rotation, _rotationSpeed);
    }
}
