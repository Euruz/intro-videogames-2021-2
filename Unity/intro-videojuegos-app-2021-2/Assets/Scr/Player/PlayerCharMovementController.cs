using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{
    private CharacterController _ch;
    private Vector3 _targetVelocity;
    private Quaternion _targetRotation;
    private float _targetRotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        _ch = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _ch.SimpleMove(_targetVelocity);
        transform.rotation = Quaternion.RotateTowards(transform.rotation,  _targetRotation, _targetRotationSpeed);
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
