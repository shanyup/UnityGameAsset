using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item DB",menuName = "Database/Item Database")]
public class ItemDB : ItemCreator
{
    public Item[] items;
    public int GetItemCount{get{return items.Length;}}

    public Item GetItem(int index)
    {
        return items[index];
    }
}
