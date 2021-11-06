using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{

    private CharacterController _rb;
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
        _rb = GetComponent<CharacterController>();
        _body = transform.Find("PlayerBody");
    }
  

    // Update is called once per frame
    void Update()
    {
        
    }
}
