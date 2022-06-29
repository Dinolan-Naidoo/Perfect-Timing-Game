using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap1Script : MonoBehaviour
{
    //Public variables
    public Rigidbody2D body2D;
    public float leftPushRange;
    public float rightPushRange;
    public float velocityThreshold;

    private void Start()
    {
        //Reference to rigidbody 
        body2D = GetComponent<Rigidbody2D>();

        //Limits the angular velocity to the threshold
        body2D.angularVelocity = velocityThreshold;
    }

    private void Update()
    {
        MoveTrap();
    }
    //Controls the swinging movement (left and right) between the two maximum ranges and threshold velocity
    public void MoveTrap()
    {
        if(transform.rotation.z > 0 
            && transform.rotation.z < rightPushRange 
            && (body2D.angularVelocity > 0)
            &&body2D.angularVelocity < velocityThreshold)
        {
            body2D.angularVelocity = velocityThreshold;
        }

        else if(transform.rotation.z < 0
            && transform.rotation.z > leftPushRange
            && (body2D.angularVelocity < 0)
            && body2D.angularVelocity > velocityThreshold * -1)
             {
               body2D.angularVelocity = velocityThreshold * -1;
             }
    }

}
