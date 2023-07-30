using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;
    public void PlayGame()
    {
        
        StartCoroutine(LoadLevel());
    }

    public void Exit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene(2);
    }
}
