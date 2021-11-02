using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neighbor : MonoBehaviour
{
    public int neighborCode;

    [HideInInspector] public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
}
