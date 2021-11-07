using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistaParent : MonoBehaviour
{
    public GameObject pista;

    bool fallen;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(!fallen && transform.localEulerAngles != Vector3.zero)
        {
            fallen = true;
        }
    }
}
