using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private KeyType keytype;
    //2 key states that are used with specific doors within the level
   public enum KeyType
   {
        Key1,
        Key2,
   }

    //Returns the key type
    public KeyType GetKeyType()
    {
        return keytype;
    }
}
