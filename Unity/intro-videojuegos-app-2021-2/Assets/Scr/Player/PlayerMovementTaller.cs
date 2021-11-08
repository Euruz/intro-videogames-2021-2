// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Player : MonoBehaviour
// {
//     [SerializeField]
//     private float _speed = 6.5f;
//     [SerializeField]
//     private float _rotationSpeed = 12f;
//     private PlayerCharMovementController _movementController;
//     private Vector2 _movementInput;
//     private Camera _cam;
//     private Quaternion _targetRotation;
//     private Vector3 targetMovementDirection;
//     private Vector3 saveMovementDirection;

//     void Start()
//     {
//         _movementController = GetComponent<PlayerCharMovementController>();
//         _cam = Camera.main;
//     }

//     void Update()
//     {
        
//         ProcessInputs();

//         //Movement
//         targetMovementDirection = new Vector3(x:_movementInput.x, y:0, z:_movementInput.y);
//         targetMovementDirection.Normalize();
//         if (targetMovementDirection.x != 0 || targetMovementDirection.z != 0)
//         {
//             saveMovementDirection = targetMovementDirection;
//             _movementController.Move(velocity:targetMovementDirection * _speed);
//             _targetRotation = Quaternion.LookRotation(targetMovementDirection);
//             _movementController.RotateTo(_targetRotation, rotationSpeed: _rotationSpeed);
//         } else {
//             _targetRotation = Quaternion.LookRotation(saveMovementDirection);
//             _movementController.RotateTo(_targetRotation, rotationSpeed: _rotationSpeed);
//         }
//     }

//     void ProcessInputs()
//     {
//         _movementInput = new Vector2(x:Input.GetAxisRaw("Horizontal"), y:Input.GetAxisRaw("Vertical"));
//         //CalculateTargetRotation();
//         //Shoot?
//     }

//     // void CalculateTargetRotation()
//     // {
//     //     Vector2 mouseScreenPosition = (Vector2)Input.mousePosition;
//     //     //_cam
//     //     RaycastHit hit;
//     //     Ray ray = _cam.ScreenPointToRay(mouseScreenPosition);

//     //     if(Physics.Raycast(ray,out hit))
//     //     {
//     //         Vector3 dir = (hit.point - transform.position).normalized;
//     //         _targetRotation = Quaternion.LookRotation(dir);
//     //     }
//     // }
// }