using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMovement : MonoBehaviour
{

    public GameObject cloudObs;

    public Rigidbody2D cloudRigidbody;

    public float lateralSpeed = 1f;
    public float pushSpeed = 10f;

    public enum Direction{left, right};
    public Direction direction;

    Vector2 movementDirection = new Vector2();
  
    void Awake() 
    {
        if(direction.ToString() == "left")
        {
            movementDirection = Vector2.left;
        }

        else
        {
            movementDirection = Vector2.right;
        }
    }
    
    void Start()
    {
        Invoke("DestroyObject", 12f);
    }

    
    void Update()
    {
        //transform.position = transform.position + lateralSpeed * Time.deltaTime * Vector3.right;

        cloudRigidbody.velocity = movementDirection * lateralSpeed;

        if(Input.anyKey)
        {
            cloudRigidbody.velocity = Vector2.left * pushSpeed;
        }
    }

    private void DestroyObject()
    {
        Destroy(gameObject);
    }
}
