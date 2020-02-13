using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMovement : MonoBehaviour
{

    public GameObject cloudObs;

    public Rigidbody2D cloudRigidbody;

    public float lateralSpeed = 1f;
  
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //transform.position = transform.position + lateralSpeed * Time.deltaTime * Vector3.right;

        cloudRigidbody.velocity = Vector2.right * lateralSpeed;
    }
}
