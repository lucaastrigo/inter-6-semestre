using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Camerinha : MonoBehaviour
{
    [HideInInspector] public Animator anim;

    public GameObject gato;
    public Vector3 offset;

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
            transform.position = gatoPos + offset;
        }
    }

    public void FadeOut()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
