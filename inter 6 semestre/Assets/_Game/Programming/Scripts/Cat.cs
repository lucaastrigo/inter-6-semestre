using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public float speed, jumpForce;

    [HideInInspector] public int andarAtual;
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

        //.normalized
        rb.velocity = new Vector3(-xMove * speed * Time.deltaTime, rb.velocity.y, zMove * speed * Time.deltaTime);

        if(rb.velocity.x != 0 || rb.velocity.z != 0)
        {
            anim.SetBool("walk", true);

            float targetAngle = Mathf.Atan2(rb.velocity.x, rb.velocity.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, targetAngle, 0);
        }
        else if(rb.velocity.x == 0 && rb.velocity.z == 0)
        {
            anim.SetBool("walk", false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            StartCoroutine(Jump());
        }
    }

    IEnumerator Jump()
    {
        anim.SetTrigger("jump");
        canJump = false;

        yield return new WaitForSeconds(0.25f);

        rb.AddForce(Vector3.up * jumpForce, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            canJump = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Andar") && other.GetComponent<AreaAndar>() != null)
        {
            andarAtual = other.GetComponent<AreaAndar>().andar;
        }
    }
}
