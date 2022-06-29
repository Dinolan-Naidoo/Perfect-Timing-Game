using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutTrigger2 : MonoBehaviour
{
    //Reference to UI images
    public GameObject TB2_1;
    public GameObject TB2_2;
    //Reference to player rigidbody
    public Rigidbody2D player;

    //Sets player veloicty to 0
    //Activates UI images
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.velocity = new Vector2(0, 0);
            TB2_1.SetActive(true);
            TB2_2.SetActive(true);
        }
    }
}
