using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float jumpForce= 8;
    bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGrounded)
        {
            jump();
        }
    }

    private void jump()
    {
        rb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
        isGrounded = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Ground")
            isGrounded=true;
    }
}
