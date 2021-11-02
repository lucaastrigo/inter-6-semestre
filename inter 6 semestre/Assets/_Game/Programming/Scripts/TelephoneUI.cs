using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelephoneUI : MonoBehaviour
{
    public GameObject[] neighbors;

    private void Start()
    {
        //
    }

    public void CallNeighbor(int code)
    {
        for (int i = 0; i < neighbors.Length; i++)
        {
            if(neighbors[i].GetComponent<Neighbor>().neighborCode == code)
            {
                neighbors[i].GetComponent<Neighbor>().anim.SetTrigger("telephone");
            }
        }
    }
}
