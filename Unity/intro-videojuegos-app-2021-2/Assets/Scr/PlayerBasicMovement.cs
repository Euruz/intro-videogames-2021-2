//What's the difference if we use Input.GetAxisRaw instead?
//   Use the console to check the difference: Debug.Log or Debug.LogError
//Which one should we use? (GetAxis or GetAxisRaw)
//Miremos que nos dice en consola GetAxis
//Debug.Log("Se obtiene " + horizontal);
//Debug.Log("Se obtiene " + vertical);
// Se notó que con GetAxis se obtiene un valor continuo entre -1 y 1 al presionar las teclas de entrada.
//Miremos que nos dice en consola GetAxisRaw
//Debug.Log("Se obtiene " + horizontal);
//Debug.Log("Se obtiene " + vertical);
// Se notó que con GetAxiRaw se obtiene un valor de -1, 0 o 1.
//What does .magnitude? (Search for Unity Vector magnitude). Why it's useful?
// Notamos que .magnitude nos da literalmente la magnitud del vector asociado en todo instante, dicha magnitud se calcula como sqrt(horizontal^2 + vertical^2)
// Es ùtil porque toma un valor unico positivo y esto sirve para programar condicionales o ciclos a partir de esto, porque nos indica que hay
// movimiento.
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasicMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField]
    private float _maxSpeed = 5f;
    [SerializeField] 
    private float _dashSpeed = 10f;
    [SerializeField] 
    private float _dashTime = 0.1f;

    private float _currentSpeed = 0.1f;
    private Vector3 _lastMovementDirection;

    private Rigidbody _rb;
    private Vector3 _dirMovement;
    private float _dashingTimer;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        bool wantDash = Input.GetKeyDown(KeyCode.LeftShift);
        
        Vector3 input = new Vector3(horizontal, 0, vertical);
        _dirMovement = input.normalized;

        if (wantDash && _dashingTimer <= 0)
        {
            _dashingTimer = _dashTime;
        }

        _dashingTimer -= Time.deltaTime;
    }

    private void FixedUpdate()
    { 
        Vector3 velocity = _dirMovement * (_dashingTimer > 0 ? _dashSpeed : _maxSpeed);
        // if (_dashingTimer > 0)
        // {
        //     velocity = _dirMovement * _dashTime;
        // }
        // else
        // {
        //     velocity = _dirMovement * _maxSpeed;
        // }
        Vector3 newPos = _rb.position + velocity * Time.deltaTime; //X = V*T
        //_rb.MovePosition(newPos);
        velocity.y = _rb.velocity.y; 
        _rb.velocity = velocity;

        //transform.position = newPos;
    }
}
