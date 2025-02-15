using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerinv : MonoBehaviour
{
    // Start is called before the first frame update
    private List<Item> items = new List<Item> { };

    public void AddItem(Item newItem) {
        items.Add(newItem);
        Debug.Log($"you have upgraed now");
        UpdatePowerUp();


    }

    void UpdatePowerUp()
    {
        GetComponent<shotaboulit>().shootsped = 0.25f;
        for (int i=0; i < items.Count; i++)
        {
            if (items[i].itemName=="apparentaly ae woll")
            {
                Debug.Log($"You found a wall");
                GetComponent<shotaboulit>().shootsped -= 0.1f;
            }
        }
    }
}