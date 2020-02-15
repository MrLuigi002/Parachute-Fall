using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMovement : MonoBehaviour
{
    public Rigidbody2D obstacleRigidbody;

    public float lateralSpeed = 1f;     //Speed it moves
    public float pushSpeed = 10f;       //Speed at which it is pushed

    public enum Direction{left, right}; //Direction selector
    public Direction direction;

    Vector2 movementDirection = new Vector2();
  
    void Awake() 
    {
        if(direction.ToString() == "left") //Direction check
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
        Invoke("DestroyObject", 12f); //Time it takes to disappear
    }

    
    void Update()
    {
        //transform.position = transform.position + lateralSpeed * Time.deltaTime * Vector3.right;

        obstacleRigidbody.velocity = movementDirection * lateralSpeed;

        if(Input.anyKey) //Push action
        {
            obstacleRigidbody.velocity = Vector2.left * pushSpeed;
        }
    }

    private void DestroyObject()
    {
        Destroy(gameObject);
    }
}
