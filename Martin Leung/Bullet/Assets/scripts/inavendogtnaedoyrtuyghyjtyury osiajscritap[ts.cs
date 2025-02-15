using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inavendogtnaedoyrtuyghyjtyuryosiajscritapts : MonoBehaviour
{
    public List<Item>items=new List<Item>();
public void AddItem(Item newItem){
    items.Add(newItem);
    Debug.Log($"added{newItem.itemName}to inventory");
}

}
