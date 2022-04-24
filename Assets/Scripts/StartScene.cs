using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{

    

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        
    }
    public void QuitGame()
    {        
        Application.Quit();
    }
}
