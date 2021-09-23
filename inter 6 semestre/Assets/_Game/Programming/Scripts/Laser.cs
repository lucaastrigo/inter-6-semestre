using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
using Cinemachine;

public class Laser : MonoBehaviour
{
    public Camera cam;
    public GameObject laser;
    public Transform catPos;

    Cat cat;
    CinemachineVirtualCamera cinemachine;
    NavMeshAgent catAgent;

    void Start()
    {
        cinemachine = GetComponent<CinemachineVirtualCamera>();
        cinemachine.m_Follow = catPos;
        cat = catPos.GetComponent<Cat>();
        catAgent = cat.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ponto = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ponto, out hit, Mathf.Infinity))
            {
                if (hit.transform.tag != "Invisible")
                {
                    catAgent.SetDestination(hit.point);
                    Instantiate(laser, catAgent.destination, Quaternion.identity);
                }
            }
        }
    }
}
