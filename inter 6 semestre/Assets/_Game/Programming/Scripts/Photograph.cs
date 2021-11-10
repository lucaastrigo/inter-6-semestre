using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System.IO;

public class Photograph : MonoBehaviour
{
    public float min, max;
    public CinemachineVirtualCamera cam;
    public GameObject album;

    private void Update()
    {
        //zooming
        if (Input.GetAxis("Mouse ScrollWheel") > 0 && cam.m_Lens.FieldOfView < max)
        {
            cam.m_Lens.FieldOfView += 5;
        }
        else if(Input.GetAxis("Mouse ScrollWheel") < 0 && cam.m_Lens.FieldOfView > min)
        {
            cam.m_Lens.FieldOfView -= 5;
        }

        //photographing
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            StartCoroutine("CaptureIt");
        }

        //album
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            album.SetActive(!album.activeSelf);
        }
    }

    IEnumerator CaptureIt()
    {
        yield return new WaitForEndOfFrame();

        Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        texture.Apply();

        //Gallery.value.SavePic(texture);
        string fileName = "Screenshot" + System.DateTime.Now.ToString("dd-MMM-yyyy_HH-mm-ss") + ".png";

        byte[] bytes = texture.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/_Game/Resources/Pictures/" + fileName, bytes);
        Destroy(texture);

        FMODUnity.RuntimeManager.PlayOneShot("event:/Foto1");
    }
}
