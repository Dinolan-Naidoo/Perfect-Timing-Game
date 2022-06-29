﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key1TriggerDestroy : MonoBehaviour
{
    [SerializeField] private Image key1Image;

    //Disables the key trigger image
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Player"|| collision.gameObject.tag =="Shield")
        {
            key1Image.enabled = false;
        }
    }
}
