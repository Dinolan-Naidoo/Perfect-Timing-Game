using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key1Trigger : MonoBehaviour
{
    //Reference to image 
    [SerializeField] public Image key1Image ;

    private void Start()
    {
        key1Image.enabled = false;
    }

  //Enables key UI when collected and disables it when used on a door
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Player"||collision.gameObject.tag =="Shield")
        {
            key1Image.enabled = true;
            
        }

        if (collision.CompareTag("Door1"))
        {
            key1Image.enabled = false;
        }
    }

    //Deactivates trigger after player leaves the trigger
    private void OnTriggerExit2D(Collider2D collision)
    {
        this.enabled = false;
    }

}
