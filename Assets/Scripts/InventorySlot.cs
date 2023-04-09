using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;

    Item item; //keeps track of item in slot 

    public void addItem(Item newitem)
    {
        item = newitem;

        icon.sprite = item.icon;
        icon.enabled = true;
    }
    public void clearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }

}
