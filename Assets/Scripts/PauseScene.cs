using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScene : MonoBehaviour
{
    //Reference to UI
    public GameObject PauseUI;

    //The following script controls the buttons for the pause menu
    private void Start()
    {
        PauseUI.SetActive(false);
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        PauseUI.SetActive(true);
    }

    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void ExitGame_()
    {
        Application.Quit();
    }
}
