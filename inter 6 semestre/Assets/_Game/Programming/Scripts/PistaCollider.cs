using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistaCollider : MonoBehaviour
{
    public GameObject pista;

    private void OnTriggerEnter(Collider collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            //Instantiate(pista, transform.position, Quaternion.identity);

            //gambiarra
            pista.SetActive(true);

            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
