using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 0.2f;
    [SerializeField]
    private float _rotationSpeed = 30f;

    private float _gravity = 9.8f;   
    private PlayerCharMovementController _movementController;

    private Camera _cam;
    
    private Vector2 _movementInput;
    private Quaternion _targetRotation;

    private Vector3 _targetMovementDirection; 

    void Start()
    {
        _movementController = GetComponent<PlayerCharMovementController>();
        _cam = Camera.main;
    }
    
    void Update()
    {
        ProcessInputs();
        
        //Movement
        _targetMovementDirection = new Vector3(_movementInput.x, 0, _movementInput.y);
        _targetMovementDirection.Normalize();
        
        //Rotation: look at movement direction
        if(_targetMovementDirection.x != 0.0 | _targetMovementDirection.z !=0.0){
            _targetRotation = Quaternion.LookRotation(_targetMovementDirection);
        }

        setGravity();
        _movementController.Move(_targetMovementDirection * _speed );
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

    void setGravity()
    {
        _targetMovementDirection.y = -_gravity;
    }

}
