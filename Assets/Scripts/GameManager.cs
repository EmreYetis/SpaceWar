using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public Button restartButton;
    public Button quitButton;

    public TextMeshProUGUI gameOverText;
    

   
    public void GameOver()
    {
        if (CounterScript.count == 0)
        {
            SceneManager.LoadScene(2);
        }               
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        
    }    
    public void QuitGame()
    {
        Application.Quit();
    }

    
}
