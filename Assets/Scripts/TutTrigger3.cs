using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutTrigger3 : MonoBehaviour
{
    //Reference ti UI images
    public GameObject TB2_1;
    public GameObject TB2_2;
    public GameObject TB3_1;
    
    //Reference to player rigidbody
    public Rigidbody2D player;

    //Sets player veloicty to 0
    //Activates UI image 3.1 and Deactivates 2.1 and 2.2
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.velocity = new Vector2(0, 0);
            TB3_1.SetActive(true);
            TB2_1.SetActive(false);
            TB2_2.SetActive(false);
        }
    }
}
