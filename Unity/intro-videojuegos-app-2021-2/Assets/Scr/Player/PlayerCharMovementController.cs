using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 _mov;
    private Quaternion _rot;
    private float _rotSpeed;
    private CharacterController _char;
    public void Move(Vector3 movimiento)
    {
        _mov = movimiento;
    }

    public void RotateTo(Quaternion rotacion, float rotationSpeed)
    {
        _rot = rotacion;
        _rotSpeed = rotationSpeed;
    }
    void Start()
    {
        _char = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _char.Move(_mov*Time.deltaTime);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, _rot, _rotSpeed * Time.deltaTime);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, _rot, _rotSpeed);
    }
}
