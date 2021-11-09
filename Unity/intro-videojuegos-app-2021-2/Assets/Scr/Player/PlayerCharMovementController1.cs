using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController1 : MonoBehaviour 
{
    public float horizontalMove;
    public float verticalMove;
    public CharacterController player;
    public float playerspeed;
    private Vector3 playerInput;
    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;
    private Vector3 movePlayer;
void Start()
{
    player = GetComponent<CharacterController>();
}
void Update()
{
    horizontalMove = Input.GetAxis("Horizontal");

    verticalMove = Input.GetAxis("Vertical");

    playerInput = new Vector3(horizontalMove, 0, verticalMove);

    playerInput = Vector3.ClampMagnitude(playerInput,1);

    Debug.Log(player.velocity.magnitude); 

    camDirection();

    movePlayer = playerInput.x * camRight + playerInput.z * camForward;

    player.transform.LookAt(player.transform.position + movePlayer);

    player.Move(movePlayer * playerspeed * Time.deltaTime); 
}
void camDirection()
{
    camForward = mainCamera.transform.forward;
    camRight = mainCamera.transform.right;
    
    camForward.y = 0;
    camRight.y = 0;
    camForward = camForward.normalized;
    camRight = camRight.normalized;
}


}
    
