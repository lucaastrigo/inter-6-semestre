using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public float speed;

    Animator anim;
    NavMeshAgent agent;
    Transform target;

    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(target != null)
        {
            //
        }
    }

    public void FollowLaser(Vector3 laserTarget)
    {
        target.position = laserTarget;
        agent.SetDestination(laserTarget);
    }
}
