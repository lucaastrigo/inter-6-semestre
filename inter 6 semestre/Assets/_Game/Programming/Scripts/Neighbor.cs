using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine;

public class Neighbor : MonoBehaviour
{
    public int neighborCode;

    public float originalRotation;
    public float speed;
    public Transform target;
    public Transform origin;
    public Animator anim;
    public Animator fade;
    public Transform porta;
    public GameObject cortinasAbertas;
    public GameObject cortinasFechadas;
    public PortaApartamento portaApto;

    bool homecoming, awayFromHome;
    Transform gato;
    Camerinha camerinha;
    NavMeshAgent navMeshAgent;

    void Start()
    {
        if(anim == null)
        {
            anim = GetComponent<Animator>();
        }
        else
        {
            navMeshAgent = anim.gameObject.GetComponent<NavMeshAgent>();
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

    public void AwayFromHome()
    {
        originalRotation = anim.transform.eulerAngles.y;
        anim.SetBool("walk", true);
        GetComponent<Collider>().enabled = false;
        awayFromHome = true;
    }

    private void Update()
    {
        if (homecoming)
        {
            if (Vector3.Distance(anim.transform.position, origin.position) > 0.5f)
            {
                navMeshAgent.SetDestination(origin.position);
                anim.transform.LookAt(origin);
            }
            else
            {
                anim.SetBool("walk", false);
                GetComponent<Collider>().enabled = true;
                anim.transform.LookAt(origin);
                homecoming = false;
                awayFromHome = false;
            }
        }

        if (awayFromHome)
        {
            if (Vector3.Distance(anim.transform.position, target.position) > 0.5f)
            {
                navMeshAgent.SetDestination(target.position);
                anim.transform.LookAt(target);
            }
            else
            {
                homecoming = true;
                awayFromHome = false;
            }
        }
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
