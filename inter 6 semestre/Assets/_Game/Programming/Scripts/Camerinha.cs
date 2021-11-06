using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Camerinha : MonoBehaviour
{
    [HideInInspector] public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void FadeOut()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
