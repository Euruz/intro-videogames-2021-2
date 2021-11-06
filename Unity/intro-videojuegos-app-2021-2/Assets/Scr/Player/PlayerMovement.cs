using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// abstract = can not be instantiated
public abstract class PlayerMovement : MonoBehaviour
{
    protected Transform _body;
    protected Vector3 _targetVelocity;
    protected Quaternion _targetRotation;
    protected float _targetRotationSpeed;

    public virtual void Move(Vector3 velocity)
    {

    }

     public virtual void RotateTo(Quaternion rotation, float rotationSpeed)
    {
  
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        _body = transform.Find("PlayerBody");
    }

    // Update is called once per frame
    void Update()
    {
         _body.rotation = Quaternion.RotateTowards(_body.rotation,  _targetRotation, _targetRotationSpeed);
    }
}
