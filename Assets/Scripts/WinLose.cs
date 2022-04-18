using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    private bool eventOver;

    public void WinEvent()
    {
        if(!eventOver)
        {
            Debug.Log("The king is dead.");
            eventOver = true;
        }
        
    }

}
