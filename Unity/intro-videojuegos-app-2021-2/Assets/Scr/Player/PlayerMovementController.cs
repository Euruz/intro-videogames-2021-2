using UnityEngine;

public class PlayerMovementController : PlayerMovement
{
    private Rigidbody _rb;
    
    public override void Move(Vector3 velocity)
    {
        _targetVelocity = velocity;
    }

    public override void RotateTo(Quaternion rotation, float rotationSpeed)
    {
        _targetRotation = rotation;
        _targetRotationSpeed = rotationSpeed;
    }

    protected override void Start()
    {
        base.Start();
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _rb.velocity = _targetVelocity;
    }
}
