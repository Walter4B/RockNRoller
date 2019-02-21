using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5.0f;
    private Rigidbody _rigidbody;
    private float _moveH;
    private float _moveV;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _moveH = Input.GetAxisRaw("Horizontal");
        _moveV = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 direction = new Vector3(_moveH, 0, _moveV);

        _rigidbody.AddForce(direction * Speed);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Speed"))
        {
            other.gameObject.SetActive(false);
            Speed *= 2;
        }
    }
}
