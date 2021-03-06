using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody rb;

    Vector3 movement;
    
    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + movement * moveSpeed*Time.fixedDeltaTime);
    }
}
