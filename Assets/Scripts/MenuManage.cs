using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManage : MonoBehaviour
{
    public List<GameObject> screens;
    
    void Start()
    {
        this.screens[0].SetActive(true);
    }

    public void UITravel(int screenToActivate)
    {
        for (int i = 0; i < this.screens.Count; i++)
        {
            if (i == screenToActivate)
            {
                this.screens[i].SetActive(true);
            }
            else
            {
                this.screens[i].SetActive(false);
            }
        }
    }

}
