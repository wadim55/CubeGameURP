using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    private string Level1 = "LevelOne";
    
    public void Play()
    {
        SceneManager.LoadScene(Level1);
    }

    public void OutApp()
    {
        Application.Quit();
    }
}
