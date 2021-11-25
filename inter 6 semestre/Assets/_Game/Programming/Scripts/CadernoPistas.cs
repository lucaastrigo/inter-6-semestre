using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CadernoPistas : MonoBehaviour
{
    public GameObject[] pistaJogo;
    public GameObject[] pistaCaderno; //ordem no caderno igual dos codigos do jogo

    public void AtivaPista(int codigo)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Anotando", GetComponent<Transform>().position);
        pistaCaderno[codigo].SetActive(true);
        //pistaJogo[codigo].GetComponent<Pista>().fotografado = true;
    }
}
