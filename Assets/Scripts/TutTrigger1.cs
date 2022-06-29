using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutTrigger1 : MonoBehaviour
{
    //References to UI images
    public GameObject TB1_1;
    public GameObject TB1_2;

    //Deactivates the images
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            TB1_1.SetActive(false);
            TB1_2.SetActive(false);
        }
    }
}
