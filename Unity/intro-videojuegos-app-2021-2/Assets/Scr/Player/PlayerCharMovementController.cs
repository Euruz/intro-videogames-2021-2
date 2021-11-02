using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{
    private CharacterController player;
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

    // Start is called before the first frame update
    void Start()
    {

        player = GetComponent<CharacterController>();
        _body = transform.Find("PlayerBody");
    }

    // Update is called once per frame
    void Update()
    {

        _body.rotation = Quaternion.RotateTowards(_body.rotation,  _targetRotation, _targetRotationSpeed);
        
    }
    void FixedUpdate()
    {
        player.Move(_targetVelocity);
    }
}
