using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{
    private CharacterController _cc;
    private Transform _body;
    
    private Vector3 _targetVelocity;
    private Quaternion _targetRotation;
    private float _targetRotationSpeed;
    private float gravity;

    public void Move(Vector3 velocity)
    {
        _targetVelocity = velocity;
        _targetVelocity.y = gravity;
    }

    public void RotateTo(Quaternion rotation, float rotationSpeed)
    {
        _targetRotation = rotation;
        _targetRotationSpeed = rotationSpeed;
        gravity = -9.81f;
    }

    private void Start()
    {
        _cc = GetComponent<CharacterController>();
        _body = transform.Find("PlayerBody");
    }

    void Update()
    {
        _body.rotation = Quaternion.RotateTowards(_body.rotation,  _targetRotation, _targetRotationSpeed);
    }

    void FixedUpdate()
    {
        _cc.Move(_targetVelocity * Time.deltaTime);
    }
}
