using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour {

    private CharacterController m_characterController;

    void Start() {
        m_characterController = GetComponent<CharacterController>();
    }

    public void Move(Vector3 velocity) {
        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        m_characterController.Move(velocity * Time.deltaTime); // X = V*T
    }

    public void RotateTo( Quaternion rotation, float rotationSpeed ) {
         transform.rotation = Quaternion.RotateTowards(transform.rotation,  rotation, rotationSpeed);
    }
}