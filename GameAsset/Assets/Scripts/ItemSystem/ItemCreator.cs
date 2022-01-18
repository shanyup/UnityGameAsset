using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreator : ScriptableObject
{
    public enum ItemType
    {
        Food,
        Jewelry,
        Armor,
        Gun,
        Potion,
        Bag
    }
    
    [Serializable] public struct Item
    {
        public string item_Name;
        public Sprite item_Sprite;
        public ItemType item_Type;
        [Range(1,100)]
        public int item_Level;
        [TextArea(5,25)]
        public string item_Description;
    }
}
