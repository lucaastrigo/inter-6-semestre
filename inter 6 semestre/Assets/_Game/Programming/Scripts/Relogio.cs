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

    private void Start()
    {
        actions = 4;
    }

    private void Update()
    {
        //relogioPreenchido.fillAmount = (float)actions / 4f;
        relogioPreenchido.fillAmount = 1 - (float)actions * 0.25f;

        float rotacaoSeta = -360 + (float)actions * 90;
        relogioSeta.eulerAngles = new Vector3(0, 0, rotacaoSeta);
    }
}
