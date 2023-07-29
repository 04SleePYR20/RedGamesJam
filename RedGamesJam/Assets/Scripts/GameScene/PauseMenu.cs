using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    // Start is called before the first frame update
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pauseMenu?.SetActive(false);
        Time.timeScale = 1;
    }

    public void LevelSelection()
    {
        SceneManager.LoadScene("LevelScene"); 
        Time.timeScale = 1;

    }

    public void Base()
    {
        SceneManager.LoadScene("BaseScene");
        Time.timeScale = 1;

    }
}
