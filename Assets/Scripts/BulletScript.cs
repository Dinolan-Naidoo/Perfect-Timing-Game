using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    //Public variables 
    public float Speed = 20f;
    public Rigidbody2D RB;
    public float rotate_Speed = 50f;

    void Start()
    {
        //Transforms the bullet to the right
        RB.velocity = transform.right.normalized * Speed;

        //Destroys bullet after 5 seconds
        Invoke("DestroyBullet", 5f);
    }

    private void Update()
    {
        RotateEnemy();
    }

    void DestroyBullet()
    {
        //Destroys bullet
        Destroy(gameObject);
    }

    void RotateEnemy()
    {
        //Rotates bullet
        transform.Rotate(new Vector3(0f, 0f, rotate_Speed * Time.deltaTime), Space.World);
    }


}
