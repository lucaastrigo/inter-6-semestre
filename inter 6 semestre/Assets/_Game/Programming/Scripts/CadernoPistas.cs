using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CadernoPistas : MonoBehaviour
{
    public GameObject[] pistaJogo;
    public GameObject[] pistaCaderno;

    public void AtivaPista(int codigo)
    {
        pistaCaderno[codigo].SetActive(true);
        pistaJogo[codigo].GetComponent<Pista>().fotografado = true;
    }
}
