using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public float speed, jumpForce;

    float xMove, zMove;
    bool canJump;
    Animator anim;
    Rigidbody rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        xMove = Input.GetAxis("Vertical");
        zMove = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3(-xMove * speed * Time.deltaTime, rb.velocity.y, zMove * speed * Time.deltaTime);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Force);

        canJump = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            canJump = true;
        }
    }
}
