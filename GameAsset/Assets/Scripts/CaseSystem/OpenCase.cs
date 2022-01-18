using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCase : MonoBehaviour
{
    public Image img;
    public ItemDB itemDB;
    public void OnClick()
    {
        int randomX = Random.Range(0, 4);
        img.sprite = itemDB.items[randomX].item_Sprite;
    }
}
