using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    [SerializeField]int sceneNum;
    public void LevelSelection(int sceneNum)
    {
        StartCoroutine(LoadLevel(sceneNum));
    }

    //public void MainMenu()
    //{
    //    StartCoroutine(LoadMain());

    //}

    //public void GameScene()
    //{
    //    StartCoroutine(LoadGame());
    //}

    //public void BaseScene()
    //{
    //    StartCoroutine(LoadBase());

    //}

    IEnumerator LoadLevel(int sceneNum)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene(sceneNum);
    }

    //IEnumerator LoadMain()
    //{
    //    transition.SetTrigger("Start");

    //    yield return new WaitForSeconds(5);

    //    SceneManager.LoadScene("MainScene");
    //}

    //IEnumerator LoadGame()
    //{
    //    transition.SetTrigger("Start");

    //    yield return new WaitForSeconds(5);

    //    SceneManager.LoadScene("GameScene");
    //}

    //IEnumerator LoadBase()
    //{
    //    transition.SetTrigger("Start");

    //    yield return new WaitForSeconds(5);

    //    SceneManager.LoadScene("BaseScene");
    //}
}
