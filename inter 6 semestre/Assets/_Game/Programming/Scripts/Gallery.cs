using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;

public class Gallery : MonoBehaviour
{
    public Object[] pictures;

    [SerializeField] GameObject panel;

    string[] files = null;
    int screenshotShown = 0;

    private void Update()
    {
        pictures = Resources.LoadAll("/Pictures/");
    }

    public void NextImage()
    {
        if(files.Length > 0)
        {
            ++screenshotShown;

            if(screenshotShown > files.Length - 1)
            {
                screenshotShown = 0;
            }

            //GetPicture();
        }
    }

    public void PreviousImage()
    {
        if(files.Length > 0)
        {
            --screenshotShown;

            if(screenshotShown < 0)
            {
                screenshotShown = files.Length - 1;
            }

            //GetPicture();
        }
    }
}
