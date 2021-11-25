using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscadaApartamento : MonoBehaviour
{
    public Transform fimDaEscada;
    public GameObject botao;

    bool podeUsar;
    Transform gato;

    private void Update()
    {
        botao.SetActive(podeUsar);
    }

    public void UsaEscada()
    {
        gato.position = fimDaEscada.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            podeUsar = true;
            gato = other.gameObject.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            podeUsar = false;
            gato = null;
        }
    }
}
