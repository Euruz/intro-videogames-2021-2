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
    private float _deceleration = 20f;
    [SerializeField]
    private float dashMultiplier = 3f;
    [SerializeField]
    private float dashDuration = 0.2f;
    

    private float _currentSpeed = 0.1f;
    private Vector3 lastMovementDirection;
    private Rigidbody rig;

    
    private float dashTimer;
    private bool isDashing;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 input = new Vector3(horizontal, 0, vertical);

        if (input.magnitude > 0)
        {
            _currentSpeed += _acceleration * Time.deltaTime;

            lastMovementDirection = input.normalized;
        }
        else
        {
            _currentSpeed -= _deceleration * Time.deltaTime;
        }

        _currentSpeed = Mathf.Clamp(_currentSpeed, 0f, _maxSpeed);

        if (Input.GetKeyDown(KeyCode.Space) && isDashing == false)
        {
            dashTimer = dashDuration;
            isDashing = true;
        }
    }
    void FixedUpdate()
    {
        if (isDashing)
        {
            _currentSpeed *= dashMultiplier;
            dashTimer -= Time.deltaTime;

            if (dashTimer <= 0)
            {
                isDashing = false;
            }

        }

        //Sin modificar la velocidad en y
        Vector3 velocity = new Vector3(lastMovementDirection.x * _currentSpeed, rig.velocity.y, lastMovementDirection.z * _currentSpeed);
        
        rig.velocity = velocity;

        
        
    }

}
