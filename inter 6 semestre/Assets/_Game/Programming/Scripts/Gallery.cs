using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;

public class Gallery : MonoBehaviour
{
    public static Gallery value;

    [SerializeField]
    List<Texture2D> pics = new List<Texture2D>();

    [SerializeField] GameObject panel;

    int screenshotShown = 0;

    public void SavePic(Texture2D texture2D)
    {
        //add 'texture2D' to 'pictures' list

        pics.Add(texture2D);
    }

    public void NextImage()
    {
        if(pics.Count > 1)
        {
            ++screenshotShown;

            if(screenshotShown > pics.Count)
            {
                screenshotShown = 0;
            }

            GetPicture();
        }

        //if(pictures.Length > 0)
        //{
        //    ++screenshotShown;

        //    if(screenshotShown > pictures.Length - 1)
        //    {
        //        screenshotShown = 0;
        //    }
        //}
    }

    public void PreviousImage()
    {
        if(pics.Count > 1)
        {
            --screenshotShown;

            if(screenshotShown < 1)
            {
                screenshotShown = pics.Count;
            }

            GetPicture();
        }

        //if(pictures.Length > 0)
        //{
        //    --screenshotShown;

        //    if(screenshotShown < 0)
        //    {
        //        screenshotShown = pictures.Length - 1;
        //    }
        //}
    }

    void GetPicture()
    {
        //
    }
}
