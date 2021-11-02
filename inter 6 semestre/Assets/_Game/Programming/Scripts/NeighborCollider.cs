using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeighborCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("vizinho pegou");
        }
    }
}
