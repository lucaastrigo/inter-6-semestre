using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System.IO;

public class Photograph : MonoBehaviour
{
    public GameObject cadernoPistas;
    public GameObject photobutton;
    public Animator vfxFlash;

    GameObject[] pistasVisiveis;
    Relogio relogio;

    private void Start()
    {
        relogio = GameObject.FindGameObjectWithTag("Relogio").GetComponent<Relogio>();
    }

    private void Update()
    {
        pistasVisiveis = GameObject.FindGameObjectsWithTag("Pista");

        for (int i = 0; i < pistasVisiveis.Length; i++)
        {
            if (pistasVisiveis[i].GetComponent<Pista>().visible && !pistasVisiveis[i].GetComponent<Pista>().fotografado)
            {
                photobutton.SetActive(true);
            }
            else
            {
                photobutton.SetActive(false);
            }
        }

        /*
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if(relogio.actions > 0)
            {
                for (int i = 0; i < pistasVisiveis.Length; i++)
                {
                    if (pistasVisiveis[i].GetComponent<Pista>().visible && !pistasVisiveis[i].GetComponent<Pista>().fotografado)
                    {
                        --relogio.actions;
                        cadernoPistas.GetComponent<CadernoPistas>().AtivaPista(pistasVisiveis[i].GetComponent<Pista>().codigoPista);
                        break;
                    }
                }
            }
        }
        */
    }

    public void Fotografar()
    {
        if (relogio.actions > 0)
        {
            for (int i = 0; i < pistasVisiveis.Length; i++)
            {
                if (pistasVisiveis[i].GetComponent<Pista>().visible && !pistasVisiveis[i].GetComponent<Pista>().fotografado)
                {
                    --relogio.actions;
                    cadernoPistas.GetComponent<CadernoPistas>().AtivaPista(pistasVisiveis[i].GetComponent<Pista>().codigoPista);
                    pistasVisiveis[i].GetComponent<Pista>().fotografado = true;
                    vfxFlash.SetTrigger("photo");
                    break;
                }
            }
        }
    }
}
