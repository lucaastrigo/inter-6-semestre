using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tab : MonoBehaviour
{
    public void Invert(GameObject target)
    {
        target.SetActive(!target.activeSelf);
    }
}
