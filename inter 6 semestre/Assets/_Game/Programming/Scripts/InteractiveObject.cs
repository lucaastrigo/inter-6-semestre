using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public UnityEvent action;
    public Transform target;

    GameObject cat;

    private void Start()
    {
        cat = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnMouseEnter()
    {
        action.Invoke();
    }

    private void OnMouseDown()
    {
        cat.transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime);

        action.Invoke();
    }
}
