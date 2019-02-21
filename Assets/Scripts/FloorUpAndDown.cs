using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorUpAndDown : MonoBehaviour
{

    public float speed = 2.0f;

    void Start()
    {

    }


    void Update()
    {
        transform.position = new Vector3(transform.position.x,(Mathf.PingPong(Time.time * speed, 10)),transform.position.z);
    }
}
