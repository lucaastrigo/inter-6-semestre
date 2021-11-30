using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Relogio : MonoBehaviour
{
    //[HideInInspector] 
    public int actions;
    public Image relogioPreenchido;
    public RectTransform relogioSeta;
    public GameObject agradecimentos;

    public GameObject[] finalDesligado;
    public GameObject[] finalLigado;

    bool final;

    private void Start()
    {
        actions = 16;
    }

    private void Update()
    {
        //relogioPreenchido.fillAmount = (float)actions / 4f;
        relogioPreenchido.fillAmount = 1 - (float)actions * 0.0625f; //era * 0.25f

        float rotacaoSeta = -360 + (float)actions * 22.5f; //era * 90
        relogioSeta.eulerAngles = new Vector3(0, 0, rotacaoSeta);




        if(actions == 0 && !final)
        {
            for (int i = 0; i < finalDesligado.Length; i++)
            {
                finalDesligado[i].SetActive(false);
            }

            for (int i = 0; i < finalLigado.Length; i++)
            {
                finalLigado[i].SetActive(true);
            }

            final = true;
        }
    }

    public void Finito()
    {
        for (int i = 0; i < finalDesligado.Length; i++)
        {
            finalDesligado[i].SetActive(false);
        }

        for (int i = 0; i < finalLigado.Length; i++)
        {
            finalLigado[i].SetActive(true);
        }
    }

    public void Agradece()
    {
        agradecimentos.SetActive(true);
    }
}
