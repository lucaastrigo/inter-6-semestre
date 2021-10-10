using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public enum cam {upCam, leftCam, downCam, rightCam}
    public cam camCode1, camCode2;

    public GameObject up, left, down, right;

    private void Update()
    {
        if(camCode1 != cam.upCam && camCode2 != cam.upCam)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                up.SetActive(true);
                left.SetActive(false);
                down.SetActive(false);
                right.SetActive(false);
            }
        }

        if(camCode1 != cam.leftCam && camCode2 != cam.leftCam)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                up.SetActive(false);
                left.SetActive(true);
                down.SetActive(false);
                right.SetActive(false);
            }
        }

        if(camCode1 != cam.downCam && camCode2 != cam.downCam)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                up.SetActive(false);
                left.SetActive(false);
                down.SetActive(true);
                right.SetActive(false);
            }
        }

        if(camCode1 != cam.rightCam && camCode2 != cam.rightCam)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                up.SetActive(false);
                left.SetActive(false);
                down.SetActive(false);
                right.SetActive(true);
            }
        }
    }
}
