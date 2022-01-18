using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character Class DB",menuName = "Database/Class Database")]
public class CharacterClassDB : CharacterClassCreator
{
    public CharacterClass[] CharacterClasses;

    public int GetClassCount(int index)
    {
        return CharacterClasses.Length;
    }

    public CharacterClass GetClass(int index)
    {
        return CharacterClasses[index];
    }
}
