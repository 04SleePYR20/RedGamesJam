using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    //[HideInInspector]
    public string itemName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            itemName = collision.gameObject.name;
            Destroy(collision.gameObject);
        }
    }
}