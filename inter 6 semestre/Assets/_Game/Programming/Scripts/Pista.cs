using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pista : MonoBehaviour
{
    [HideInInspector] public bool visible;

    private void OnBecameVisible()
    {
        print("pista visivel na tela");
        visible = true;
    }

    private void OnBecameInvisible()
    {
        print("pista INVISIVEL");
        visible = false;
    }
}
