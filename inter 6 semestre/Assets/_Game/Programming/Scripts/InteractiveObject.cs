using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public UnityEvent action;

    GameObject cat;

    private void Start()
    {
        cat = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnMouseEnter()
    {
        action.Invoke();
    }
}
