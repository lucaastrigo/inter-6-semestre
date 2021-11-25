using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Neighbor : MonoBehaviour
{
    public int neighborCode;

    public Animator anim;
    public Animator fade;
    public Transform porta;
    public GameObject cortinasAbertas;
    public GameObject cortinasFechadas;
    public PortaApartamento portaApto;

    Transform gato;
    Camerinha camerinha;

    void Start()
    {
        if(anim == null)
        {
            anim = GetComponent<Animator>();
        }

        camerinha = GameObject.FindGameObjectWithTag("Camera").GetComponent<Camerinha>();
    }

    IEnumerator Bloqueia()
    {
        cortinasAbertas.SetActive(false);
        cortinasFechadas.SetActive(true);
        portaApto.botaoEntrar.GetComponent<Image>().color = Color.gray;
        portaApto.botaoEntrar.GetComponent<Button>().enabled = false;
        portaApto.dentroApartamento = false;

        yield return new WaitForSecondsRealtime(20);

        cortinasAbertas.SetActive(true);
        cortinasFechadas.SetActive(false);
        portaApto.botaoEntrar.GetComponent<Image>().color = Color.white;
        portaApto.botaoEntrar.GetComponent<Button>().enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && portaApto.dentroApartamento)
        {
            gato = other.gameObject.transform;
            gato.position = porta.position;
            camerinha.anim.SetTrigger("vizinho");
            fade.SetTrigger("fade");
            FMODUnity.RuntimeManager.PlayOneShot("event:/Flagra1");
            StartCoroutine(Bloqueia());
        }
    }
}
