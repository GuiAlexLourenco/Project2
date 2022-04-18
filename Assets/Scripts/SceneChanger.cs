using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void Scene1908Travel()
    {
        SceneManager.LoadScene(1);
    }

    public void Scene1910Travel()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenuTravel()
    {
        SceneManager.LoadScene(0);
    }

}
