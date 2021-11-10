using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neighbor : MonoBehaviour
{
    public int neighborCode;

    [HideInInspector] public Animator anim;

    Camerinha camerinha;

    void Start()
    {
        anim = GetComponent<Animator>();
        camerinha = GameObject.FindGameObjectWithTag("Camera").GetComponent<Camerinha>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("vizinho pegou");
            camerinha.anim.SetTrigger("vizinho");
            FMODUnity.RuntimeManager.PlayOneShot("event:/Flagra1");
        }
    }
}
