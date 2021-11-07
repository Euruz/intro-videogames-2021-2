using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPlayer : MonoBehaviour
{
    [SerializeField]
    private float _speed = 6.5f;
    [SerializeField]
    private float _rotationSpeed = 30f;
    
    private FixPlayerMovementController _fixmovementController;

    private Camera _cam;
    
    private Vector2 _movementInput;
    private Quaternion _targetRotation;
    private Vector2 _rotate;

    void Start()
    {
        _fixmovementController = GetComponent<FixPlayerMovementController>();
        _cam = Camera.main;
        
    }
    
    void Update()
    {
        ProcessInputs();
        //Movement
        Vector3 targetMovementDirection = new Vector3(_movementInput.x, 0f, _movementInput.y);
        
        targetMovementDirection.Normalize();
        
        //Rotation: look at movement direction
        _rotate += _movementInput * _rotationSpeed;
        _rotate.Normalize();
        _rotate.x = Mathf.Clamp(_rotate.x, -1f, 1f);
        _rotate.y = Mathf.Clamp(_rotate.y, -1f, 1f);

        Vector3 rotacioncita = new Vector3(_rotate.x , 0f, _rotate.y);

        _targetRotation = Quaternion.LookRotation(rotacioncita);
        Debug.Log(rotacioncita);
        
        
        _fixmovementController.Move( targetMovementDirection * _speed );
        _fixmovementController.RotateTo( _targetRotation, _rotationSpeed );
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
