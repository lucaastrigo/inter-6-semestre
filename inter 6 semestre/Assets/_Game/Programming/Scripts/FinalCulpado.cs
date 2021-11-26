using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FinalCulpado : MonoBehaviour
{
    public int culpadoCerto;
    public Sprite[] imagem;
    public GameObject[] certos;
    public GameObject[] erros;
    public GameObject[] desliga;

    int index;
    Image image;

    private void Start()
    {
        index = 0;

        image = GetComponent<Image>();
    }

    public void Next()
    {
        if(index >= imagem.Length - 1)
        {
            index = 0;
        }
        else
        {
            ++index;
        }

        image.sprite = imagem[index];
    }

    public void Previous()
    {
        if (index <= 0)
        {
            index = imagem.Length - 1;
        }
        else
        {
            --index;
        }

        image.sprite = imagem[index];
    }

    public void Culpar()
    {
        if(index == culpadoCerto)
        {
            for (int i = 0; i < certos.Length; i++)
            {
                certos[i].SetActive(true);
            }

            for (int j = 0; j < desliga.Length; j++)
            {
                desliga[j].SetActive(false);
            }
        }
        else
        {
            for (int i = 0; i < erros.Length; i++)
            {
                erros[i].SetActive(true);
            }

            for (int j = 0; j < desliga.Length; j++)
            {
                desliga[j].SetActive(false);
            }
        }
    }
}
