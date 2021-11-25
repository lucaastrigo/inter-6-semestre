using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Canvas>().worldCamera = GameObject.FindGameObjectWithTag("Cam").GetComponent<Camera>();
    }

    private void LateUpdate()
    {
        transform.LookAt(transform.position + GameObject.FindGameObjectWithTag("Cam").GetComponent<Camera>().transform.forward);
    }
}
