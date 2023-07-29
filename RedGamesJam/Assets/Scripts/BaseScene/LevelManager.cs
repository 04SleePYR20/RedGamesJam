using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public void LevelSelection()
    {
        SceneManager.LoadScene("LevelScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainScene");
    }
}
