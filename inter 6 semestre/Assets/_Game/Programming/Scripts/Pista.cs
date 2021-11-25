using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pista : MonoBehaviour
{
    [HideInInspector] public bool visible;
    [HideInInspector] public bool fotografado;

    public int codigoPista;
    public GameObject semFotoFX;

    private void Update()
    {
        semFotoFX.SetActive(!fotografado);
    }

    private void OnBecameVisible()
    {
        visible = true;
    }

    private void OnBecameInvisible()
    {
        visible = false;
    }
}
