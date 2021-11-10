using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neighbor : MonoBehaviour
{
    public int neighborCode;

    public Animator anim;

    Camerinha camerinha;

    void Start()
    {
        if(anim == null)
        {
            anim = GetComponent<Animator>();
        }

        camerinha = GameObject.FindGameObjectWithTag("Camera").GetComponent<Camerinha>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            camerinha.anim.SetTrigger("vizinho");
            FMODUnity.RuntimeManager.PlayOneShot("event:/Flagra1");
        }
    }
}
