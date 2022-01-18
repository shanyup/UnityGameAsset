using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CharacterClassCreator : ScriptableObject
{
    public enum ClassName
    {
        DenemeIrk1,
        DenemeIrk2
    }
    [Serializable]public struct CharacterClass 
    {
        //public string Class_Name;
        //I will add button for new class names. They will be added "ClassName" enum.
        public ClassName ClassName;
        [Header("Character Class Settings")]
        public GameObject type1;
        public GameObject type2;
        [Space]
        [Header("Character Stats")]
        public int Health;
        public int Speed;
        public int Damage;
    }

    public void AddClass(string className)
    {
        
    }
}