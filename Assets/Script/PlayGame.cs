using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour
{

    public void play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    
    public void Quit()
    {
        Application.Quit();

    }
    public void Credits()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
    