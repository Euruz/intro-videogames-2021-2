using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{
    private CharacterController _rb;
    private Transform _body;
    private float hmove;
    private Vector3 _targetVelocity;
    private Quaternion _targetRotation;
    private float _targetRotationSpeed;
    private float ymove;
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
        _rb = GetComponent<CharacterController>();
        _body = transform.Find("PlayerBody");
        
    }

    void Update()
    {
        hmove =  Input.GetAxis("Horizontal");
        ymove =  Input.GetAxis("Vertical");
        _body.rotation = Quaternion.RotateTowards(_body.rotation,  _targetRotation, _targetRotationSpeed);
    }

    void FixedUpdate()
    {
        //_rb.velocity = new Vector3(hmove,0,ymove);
        _rb.Move(new Vector3(hmove,0,ymove));
    }
}

