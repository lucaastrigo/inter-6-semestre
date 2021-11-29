using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelephoneUI : MonoBehaviour
{
    public GameObject[] neighbors;

    Relogio relogio;

    private void Start()
    {
        relogio = GameObject.FindGameObjectWithTag("Relogio").GetComponent<Relogio>();
    }

    public void CallNeighbor(int code)
    {
        if(relogio.actions > 0)
        {
            --relogio.actions;

            for (int i = 0; i < neighbors.Length; i++)
            {
                if (neighbors[i].GetComponent<Neighbor>().neighborCode == code)
                {
                    neighbors[i].GetComponent<Neighbor>().AwayFromHome();
                }
            }
        }
    }
}
