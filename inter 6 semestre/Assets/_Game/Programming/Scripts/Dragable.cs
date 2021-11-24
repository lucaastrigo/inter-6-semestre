using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragable : MonoBehaviour
{
    bool startDrag;

    void Update()
    {
        if (startDrag)
        {
            transform.position = Input.mousePosition;
        }
    }

    public void StartDrag()
    {
        startDrag = true;
    }

    public void EndDrag()
    {
        startDrag = false;
    }
}
