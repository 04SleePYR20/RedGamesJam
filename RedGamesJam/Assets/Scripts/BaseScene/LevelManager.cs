using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;
    public void LevelSelection()
    {
        StartCoroutine(LoadLevel());
    }

    public void MainMenu()
    {
        StartCoroutine(LoadMain());

    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("LevelScene");
    }

    IEnumerator LoadMain()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("MainScene");
    }
}
