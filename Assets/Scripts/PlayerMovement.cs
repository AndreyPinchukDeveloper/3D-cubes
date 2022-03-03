using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    public float accelerateSpeed = 1f;
    public float maximumSpeed = 5f;
    private Vector3 input;

    public Rigidbody rb;

    private void Start()
    {
        
    }

    void Update()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        if (rb.velocity.magnitude < maximumSpeed)
        {
            rb.AddForce(input * accelerateSpeed, ForceMode.Acceleration);
        }
    }


}
