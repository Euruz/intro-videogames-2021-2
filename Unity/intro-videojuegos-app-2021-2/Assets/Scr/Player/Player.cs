using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 6.5f;
    [SerializeField]
    private float _rotationSpeed = 30f;

    [SerializeField]
    private float _oldRotationSpeedX = 0f;

    [SerializeField]
    private float _oldRotationSpeedY = 0f;
    
    private PlayerMovementController _movementController;

    private Camera _cam;
    
    private Vector2 _movementInput;
    private Quaternion _targetRotation;

    void Start()
    {
        _movementController = GetComponent<PlayerMovementController>();
        _cam = Camera.main;
    }

    void Update()
    {
        ProcessInputs();
        //Movement
        Vector3 targetMovementDirection = new Vector3(_movementInput.x, 0, _movementInput.y);
        targetMovementDirection.Normalize();
        
        _movementController.Move( targetMovementDirection * _speed );

        //Rotation: look at movement direction
        float _newRotationSpeedX = _oldRotationSpeedX;
        float _newRotationSpeedY = _oldRotationSpeedY;

        if ( _movementInput.x != 0)
        {
            _newRotationSpeedX = _movementInput.x;
            if (_movementInput.y == 0)
            {
                _newRotationSpeedY = _movementInput.y;
            }
        }

        if ( _movementInput.y != 0)
        {
            _newRotationSpeedY = _movementInput.y;
            if (_movementInput.x == 0)
            {
                _newRotationSpeedX = _movementInput.x;
            }
        }
        
        Vector3 targetRotationDirection = new Vector3(_newRotationSpeedX, 0, _newRotationSpeedY);
        targetRotationDirection.Normalize();

        _targetRotation = Quaternion.LookRotation(targetRotationDirection);
        
        _oldRotationSpeedX = _newRotationSpeedX;
        _oldRotationSpeedY = _newRotationSpeedY;
        
        _movementController.RotateTo( _targetRotation, _rotationSpeed );
    }

    void ProcessInputs()
    {
        _movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //Process rotation
        //CalculateTargetRotation();
    }

    void CalculateTargetRotation()
    {
        //We made a raycast to detect where the mouse is in our 3D space
        Vector2 mouseScreenPosition = Input.mousePosition;
        
        //Will contain all the info result from the raycast hit.
        //Check https://docs.unity3d.com/ScriptReference/RaycastHit.html for more info.
        RaycastHit hit; 
        
        //Create the Ray. In this case we use the camera cause we need to convert the 
        //  mouse position (Screen coordinates) to a 3D point (World space).
        Ray ray = _cam.ScreenPointToRay(mouseScreenPosition);
        
        //Process Raycast using the Physics engine
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 dir = (hit.point - transform.position).normalized;
            _targetRotation = Quaternion.LookRotation(dir);
        }
    }
}
