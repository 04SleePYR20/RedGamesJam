using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [HideInInspector]
    public List<GameObject> itemsOnScene = new List<GameObject>();
    //[HideInInspector]
    public List<GameObject> itemsCollected = new List<GameObject>();

    [HideInInspector]
    public bool pickedUp = false;

    private void Start()
    {
        itemsCollected.Clear();
        itemsOnScene.AddRange(GameObject.FindGameObjectsWithTag("Item"));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            for (int i = 0; i < itemsOnScene.Count; i++)
            {
                if (collision.gameObject == itemsOnScene[i])
                {
                    itemsCollected.Add(itemsOnScene[i]);
                    pickedUp = true;
                    collision.gameObject.SetActive(false);
                    break;
                }
            }
        }
    }
}