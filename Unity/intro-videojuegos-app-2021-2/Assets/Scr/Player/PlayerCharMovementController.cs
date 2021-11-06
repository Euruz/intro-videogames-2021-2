using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{

    private CharacterController _rb;
    private Transform _body;

    private Vector3 _targetVelocity;
    private Quaternion _targetRotation;
    public float _gravity = 2000.0f;
    private float _targetRotationSpeed;

    public void Move(Vector3 velocity)
    {
        velocity.y = velocity.y - (_gravity * Time.deltaTime);
        _rb.Move(velocity * Time.deltaTime);
       // _targetVelocity = velocity;
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
  

    // Update is called once per frame
    void Update()
    {
        _body.rotation = Quaternion.RotateTowards(_body.rotation, _targetRotation, _targetRotationSpeed);
    }

  
}
