using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //this will allow us to save as a file
public class PlayerData
{
    //set and save all the player properties/data
    public int level;
    public object[] inventory; //not sure how the inventory is going to be stored, so I am keeping it like this
    public float[] position;

    public PlayerData(Player player)
    {
        level = player.level;
        inventory = player.inventory;
        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }
}

