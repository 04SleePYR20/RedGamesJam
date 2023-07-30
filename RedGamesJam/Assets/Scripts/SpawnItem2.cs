using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem2 : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    public Transform[] spawnPosition;
    public int speed = 16;

    private void Start()
    {
        items.AddRange(GameObject.FindGameObjectsWithTag("Item"));

        for (int i = 0; i < items.Count; i++)
        {
            items[i].transform.position = Vector2.MoveTowards(spawnPosition[i].transform.position, spawnPosition[i].transform.position, speed * Time.deltaTime);
        }

    }
}
