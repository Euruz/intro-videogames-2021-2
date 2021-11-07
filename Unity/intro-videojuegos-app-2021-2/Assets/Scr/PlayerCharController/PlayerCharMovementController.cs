using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{
        private CharacterController bodycon;
    public Transform bodytrans;
    private Vector2 mov;




    public void Move(float speed){

        mov.x = Input.GetAxisRaw("Horizontal");
        mov.y = Input.GetAxisRaw("Vertical");

        bodycon.Move(new Vector3(mov.x * speed * Time.deltaTime, 0 , mov.y * speed * Time.deltaTime));
    }

    public void RotateTo(Quaternion rotation, float rotationSpeed){

        //El codigo pro
        Vector3 rot = new Vector3(0, rotation.eulerAngles.y, 0);

        Quaternion rot2 = Quaternion.Euler(rot.x, rot.y , rot.z);
        
        bodytrans.rotation = Quaternion.RotateTowards(bodytrans.rotation, rot2, rotationSpeed);
    }

    public void Gravity(){

        float grav = -9.81f;

        if(bodycon.isGrounded == false){
            bodycon.Move(new Vector3(0, grav * Time.deltaTime,0));
        }
    }

    void Start()
    {
        bodycon = GetComponent<CharacterController>();
        bodytrans = GetComponent<Transform>();
    }

    void Update()
    {
        
    }
}
