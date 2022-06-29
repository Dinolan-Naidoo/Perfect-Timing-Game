using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    //Public variables
    public Transform FirePoint;
    public float startShooting;
    public GameObject bulletRef;

    //Private variables
    private float TimedShots;

    private void Start()
    {
        //Makes sure that Timed shots ans start shooting are equal to each other at the start of the game
        TimedShots = startShooting;
    }


    void Update()
    {

        if (TimedShots <= 0)
        {
            //Shoots a bullet once the timer has reached zero
            shoot();

            //Makes sure that timed shots is equal to start shooting 
            TimedShots = startShooting;

        }
        else
        {
            //Operates as a decrement timer for the shots
            TimedShots -= Time.deltaTime;
        }
    }

    //Instantiates bullets at FirePoint
    void shoot()
    {
        Instantiate(bulletRef, FirePoint.position, FirePoint.rotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
