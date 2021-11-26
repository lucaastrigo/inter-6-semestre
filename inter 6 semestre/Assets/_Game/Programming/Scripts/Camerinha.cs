using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Camerinha : MonoBehaviour
{
    [HideInInspector] public Animator anim;

    public GameObject gato;

    void Start()
    {
        anim = GetComponent<Animator>();
        FMODUnity.RuntimeManager.PlayOneShot("event:/AmbienteCidade", GetComponent<Transform>().position);
    }

    private void Update()
    {
        if(gato != null)
        {
            Vector3 gatoPos = gato.transform.position;
            gatoPos.x = transform.position.x;

            if(gato.GetComponent<Cat>() != null)
            {
                switch (gato.GetComponent<Cat>().andarAtual)
                {
                    case 0:
                        gatoPos.y = 1.61f;
                        break;
                    case 1:
                        gatoPos.y = 4.06f;
                        break;
                    case 2:
                        gatoPos.y = 6.51f;
                        break;
                }
            }

            transform.position = gatoPos;
        }
    }
}
