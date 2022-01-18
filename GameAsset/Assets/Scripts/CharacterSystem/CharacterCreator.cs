using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
 
public class CharacterCreator : MonoBehaviour
{
    public InputField inputChName;
    public string Ch_Name;
    public CharacterClassDB ClassDB;
    public Scrollbar CharacterTip;
    public GameObject selectionCH;
    public class Character
    {
        
    }

    private void Update()
    {
        string Ch_Name = inputChName.text;
        SelectTip(ClassDB,CharacterTip);
    }

    public void SelectTip(CharacterClassDB classDB,Scrollbar selectTip)
    {
        if (selectTip.value == 0)
        {
            selectionCH = classDB.CharacterClasses[0].type1;
        }
        else
        {
            selectionCH = classDB.CharacterClasses[0].type2;
        }
    }
}
