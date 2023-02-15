using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Lose : MonoBehaviour
{
    public void LoadToScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadToScene2()
    {
        SceneManager.LoadScene(0);
    }




}
