using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{
    private Vector3 _targetVelocity;
    private Quaternion _targetRotation;
    private float _targetRotationSpeed;
    private Transform _body;
    // Start is called before the first frame update
    private CharacterController characterController;
    private Vector3 moveDirection = Vector3.zero;
    public void Move(Vector3 v)
    {
        _targetVelocity = v/100;
    }
    public void RotateTo(Quaternion rotation, float rotationSpeed)
    {
        _targetRotation = rotation;
        _targetRotationSpeed = rotationSpeed;
    }
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        _body = transform.Find("PlayerBody");
    }

    // Update is called once per frame
    public void Update()
    {
        characterController.Move(_targetVelocity);
        _body.rotation = Quaternion.RotateTowards(_body.rotation,  _targetRotation, _targetRotationSpeed);
    }
}
