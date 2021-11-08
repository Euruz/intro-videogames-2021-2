using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharMovementController : MonoBehaviour
{
  private CharacterController _cc;
  private Transform _body;
  private Vector3 _targetVelocity;
  private Quaternion _targetRotation;
  private float _targetRotationSpeed;
  void Start()
  {
    _cc = GetComponent<CharacterController>();
    _body = transform.Find("PlayerBody");
  }

  // Update is called once per frame
  void Update()
  {
    _body.rotation = Quaternion.RotateTowards(_body.rotation, _targetRotation, _targetRotationSpeed);
  }

  void FixedUpdate()
  {
    _cc.SimpleMove(_targetVelocity);
  }

  public void Move(Vector3 velocity)
  {
    _targetVelocity = velocity;
  }

  public void RotateTo(Quaternion rotation, float rotationSpeed)
  {
    _targetRotation = rotation;
    _targetRotationSpeed = rotationSpeed;
  }
}
