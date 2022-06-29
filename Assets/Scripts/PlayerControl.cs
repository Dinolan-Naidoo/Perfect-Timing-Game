using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    //private variables
    private GameObject mousePointA; //Reference to distance point A
    private GameObject mousePointB; //Reference to distance point B
    private CircleCollider2D playerColliders; // Reference to colliders
    private Rigidbody2D rB; //Reference to rigidbody
    private float currentdistance; //Current distance of mouse drag
    private float safeSpace =1f; // Exists within current distance and max distance
    private float shootpower; // The power that the player can be propelled 
    private Vector3 shootDirection; // The direction vector that the player is being moved to 

    //public variables
    public float maxdistance = 2f; // Max distance of mouse drag
    public GameObject pause;

    private void Awake()
    {
        mousePointA = GameObject.FindGameObjectWithTag("PointA"); 
        mousePointB = GameObject.FindGameObjectWithTag("PointB"); 
        mousePointB.SetActive(false);
        playerColliders = GetComponent<CircleCollider2D>();
        rB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Checks first whether the pause menu is open before allowing the player to move
        if (pause.gameObject.activeSelf == true)
        {
            Time.timeScale = 0f;
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                mousePointB.SetActive(true);
                Time.timeScale = 0.1f;
                Time.fixedDeltaTime = Time.timeScale * 0.1f;
                currentdistance = Vector3.Distance(mousePointA.transform.position, transform.position);
                currentdistance = Mathf.Abs(2f);

                if (currentdistance <= maxdistance)
                {
                    safeSpace = currentdistance;
                }

                else
                {
                    safeSpace = maxdistance;
                }

                //Power of shot
                shootpower = Mathf.Abs(safeSpace) * 10f;
                Vector3 Dxy = mousePointA.transform.position - transform.position;
                float difference = Dxy.magnitude;
                mousePointB.transform.position = transform.position + ((Dxy / difference) * currentdistance * -1);
                mousePointB.transform.position = new Vector3(mousePointB.transform.position.x, mousePointB.transform.position.y, -1.5f);

                //Direction of shot
                shootDirection = Vector3.Normalize(mousePointA.transform.position - transform.position);
            }

            //Handles the player movement when the left click is released
            if (Input.GetMouseButtonUp(0))
            {
                Time.timeScale = 1;
                Vector3 push = shootDirection * shootpower * -1f;
                rB.velocity = push;
                mousePointB.SetActive(false);
            }
        }
        //Handles mouse left click input
        
    }
}
