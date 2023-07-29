using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [HideInInspector]
    public string itemName;

    //public string[] items;

    //public List<Item> items = new List<Item>();

    [HideInInspector]
    public bool pickedUp = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            itemName = collision.gameObject.name;
            pickedUp = true;
            Destroy(collision.gameObject);
        }
    }

/*    [System.Serializable]
    public class Item
    {
        public string itemName;
    }
*/}