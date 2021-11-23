using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void NextCutscene()
    {
        int i = anim.GetInteger("id");
        int j = i + 1;
        anim.SetInteger("id", j);
    }
}
