using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{
    [SerializeField] CharacterController controller;

    [SerializeField] float speed = 12f;
    [SerializeField] float RotationSpeed = 1500f;
    private Transform _body;
    
    private Vector3 _targetVelocity;
    private Quaternion _targetRotation;
    private float _targetRotationSpeed;
    float x,z;
    Vector3 move;

    public void Move (Vector2 Directions)
    {
        x = Directions.x;
        z = Directions.y;
        move = transform.right * x + transform.forward * z;
    }

    public void RotateTo(Vector3 MovementDirection)
    {
        if (MovementDirection != Vector3.zero)
        {
            //Rotation: look at movement direction
            _targetRotation = Quaternion.LookRotation(MovementDirection, Vector3.up);
            //this.transform.rotation = Quaternion.RotateTowards (transform.rotation, _targetRotation, RotationSpeed*Time.deltaTime);
            _body.rotation = Quaternion.RotateTowards(_body.rotation,  _targetRotation, RotationSpeed*Time.deltaTime);
        }
    }

    private void Start()
    {
        _body = transform.Find("PlayerBody");
    }

    void Update()
    {
        controller.Move(move*speed*Time.deltaTime);
    }

}
