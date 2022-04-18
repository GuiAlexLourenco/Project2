using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool finalPlace;

    public WinLose winScript;

    private void OnTriggerEnter(Collider other)
    {
        if (finalPlace == true)
        {
            winScript.WinEvent();
        }

        Destroy(gameObject);
    }
}
