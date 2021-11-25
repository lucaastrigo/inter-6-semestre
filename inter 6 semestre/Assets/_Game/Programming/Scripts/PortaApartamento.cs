using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaApartamento : MonoBehaviour
{
    public bool dentroApartamento;
    public Transform dentro;
    public Transform fora;
    public GameObject botaoEntrar;
    public GameObject botaoSair;

    bool podeSair;
    Transform gato;
    Relogio relogio;

    private void Start()
    {
        relogio = GameObject.FindGameObjectWithTag("Relogio").GetComponent<Relogio>();
    }

    void Update()
    {
        if (podeSair)
        {
            if (dentroApartamento)
            {
                botaoSair.SetActive(true);
                botaoEntrar.SetActive(false);
            }
            else
            {
                botaoSair.SetActive(false);
                botaoEntrar.SetActive(true);
            }
        }
        else
        {
            botaoSair.SetActive(false);
            botaoEntrar.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            podeSair = true;
            gato = other.gameObject.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            podeSair = false;
            gato = null;
        }
    }

    public void SairApartamento()
    {
        if (podeSair)
        {
            gato.position = fora.position;

            dentroApartamento = false;
        }
    }

    public void EntrarApartamento()
    {
        if(relogio.actions > 0)
        {
            if (podeSair)
            {
                --relogio.actions;

                gato.position = dentro.position;

                dentroApartamento = true;
            }
        }
    }
}
