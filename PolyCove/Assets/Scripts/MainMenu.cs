using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private string firstLevel = "Level1";

    public void PlayGame()
    {
        SceneManager.LoadScene(this.firstLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
