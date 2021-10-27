using UnityEngine;

public class PlayerBasicMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField]
    private float _maxSpeed = 5f;
    [SerializeField]
    private float _dashSpd = 15f;
    [SerializeField]
    private float _dashT = 0.7f;
    
    
    private Vector3 lastMovementDirection;
    private float _dashingT; 
    
    void Update()
    {
 
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        bool _isDashing = Input.GetKeyDown(KeyCode.LeftShift);

        Vector3 input = new Vector3(horizontal, 0, vertical);
        lastMovementDirection = input.normalized;

        if(_isDashing && _dashingT <= 0){
            _dashingT = _dashT;
        }

        _dashingT -= Time.deltaTime;
    }

    private void FixedUpdate(){
        
        Vector3 velocity = lastMovementDirection * (_dashingT > 0 ? _dashSpd : _maxSpeed);
        Vector3 movement = velocity * Time.deltaTime;
        
        transform.position += movement;
    }
    
}
