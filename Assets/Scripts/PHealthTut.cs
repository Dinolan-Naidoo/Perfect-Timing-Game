using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PHealthTut : MonoBehaviour

{
    //private variables
    private CircleCollider2D playerColliders;

    //public variables
    public GameObject shield;
    public Image ShieldImage;



    private void Start()
    {
        //Reference to player's circle collider
        playerColliders = GetComponent<CircleCollider2D>();
        //Deactivates shield
        shield.SetActive(false);
        //Deactivates shield image
        ShieldImage.enabled = false;
    }

    //Checks for collisions with bullet or trap
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet" && playerColliders.enabled == true || collision.gameObject.tag == "Trap" && playerColliders.enabled == true)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("YouLoseTut");
        }
    }

    //Activates shield mechanic
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shield")
        {
            playerColliders.enabled = false;
            shield.SetActive(true);
            ShieldImage.enabled = true;
            Invoke("DeactivateShield", 6f);
        }
    }

    //Deactivates shield mechanic
    private void DeactivateShield()
    {
        shield.SetActive(false);
        ShieldImage.enabled = false;
        playerColliders.enabled = true;
    }
}
