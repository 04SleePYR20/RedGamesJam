using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Extraction : MonoBehaviour
{
    [SerializeField]
    PickUp pu;

    [SerializeField]
    int scene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (pu.itemName != null)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
