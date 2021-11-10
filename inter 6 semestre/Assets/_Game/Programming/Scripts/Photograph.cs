using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System.IO;

public class Photograph : MonoBehaviour
{
    public GameObject cadernoPistas;

    GameObject[] pistasVisiveis;

    private void Update()
    {
        pistasVisiveis = GameObject.FindGameObjectsWithTag("Pista");

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            for (int i = 0; i < pistasVisiveis.Length; i++)
            {
                if (pistasVisiveis[i].GetComponent<Pista>().visible && !pistasVisiveis[i].GetComponent<Pista>().fotografado)
                {
                    cadernoPistas.GetComponent<CadernoPistas>().AtivaPista(pistasVisiveis[i].GetComponent<Pista>().codigoPista);
                }
            }
        }
    }
}
