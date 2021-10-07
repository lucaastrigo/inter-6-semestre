using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public void SelectCamera(GameObject toActivate, GameObject[] toDeactivate)
    {
        toActivate.SetActive(true);

        for (int i = 0; i < toDeactivate.Length; i++)
        {
            toDeactivate[i].SetActive(false);
        }
    }
}
