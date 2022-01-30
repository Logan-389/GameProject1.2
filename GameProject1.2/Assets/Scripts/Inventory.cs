using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    static HashSet<string> items = new HashSet<string>();

    Item itemToPickUp;


    void Update() {
        if (itemToPickUp != null && Input.GetKeyDown(KeyCode.E))
        {
            items.Add(itemToPickUp.id);
            Destroy(itemToPickUp.gameObject);
            itemToPickUp = null;
        }
    }

    void OnTriggerEnter(Collider collider) {
        itemToPickUp = collider.GetComponent<Item>();
    }

    void OnTriggerExit(Collider collider) {
        var item = collider.GetComponent<Item>();
        if (item != null)
        {
            itemToPickUp = null;
        }
    }



}
