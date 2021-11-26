using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistaCollider : MonoBehaviour
{
    public GameObject pista;

    private void OnTriggerEnter(Collider collision)
    {
        if (!collision.gameObject.CompareTag("Player") && !collision.gameObject.CompareTag("Pista") && !collision.gameObject.CompareTag("Andar") && !collision.gameObject.CompareTag("Vizinho"))
        {
            //Instantiate(pista, transform.position, Quaternion.identity);

            //gambiarra
            print(collision.name + " destruiu tudo");

            if(pista != null)
            {
                pista.SetActive(true);
            }

            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
