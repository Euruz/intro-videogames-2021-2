using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasicMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField]
    private float _maxSpeed = 5f;
    [SerializeField]
    private float _acceleration = 15f;
    [SerializeField]
    private float _deceleration = 15f;
    
    
    private float _currentSpeed = 0.1f;
    private Vector3 lastMovementDirection;

    private Rigidbody _rb;

    [SerializeField]
    private float  _dashSpeed = 10f;

    [SerializeField]
    private float  _dashTime = 0.1f;
    private Vector3 _dirMovement;
    private bool _isDashing;
    private float _dashingTimer;

    private void Start() {

        _rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        _isDashing = Input.GetKeyDown(KeyCode.Space);


        Vector3 input = new Vector3(horizontal, 0, vertical);
        _dirMovement = input.normalized();

        if (_isDashing){
            _dashingTimer = _dashTime;
        }

        _dashingTimer -= Time.deltaTime;

        // if (input.magnitude > 0)
        // {
        //     _currentSpeed += _acceleration * Time.deltaTime;
            
        //     lastMovementDirection = input;
        // }
        // else
        // {
        //     _currentSpeed -= _deceleration * Time.deltaTime;
        // }

        // //https://docs.unity3d.com/ScriptReference/Mathf.Clamp.html
        // _currentSpeed = Mathf.Clamp(_currentSpeed, 0f, _maxSpeed);
        
        // Vector3 velocity = lastMovementDirection * _currentSpeed;
        // Vector3 movement = velocity * Time.deltaTime;
        
        // transform.position += movement;
    } 
     private void FixedUpdate() {
        vector3 velocity = _dirMovement + (_dashingTimer > 0 ? _dashSpeed : _maxSpeed);

     }
    
}
