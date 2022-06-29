using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    private void FixedUpdate()
    {
        //The camera follows the player
        transform.position = new Vector3(Player.position.x, Player.position.y, transform.position.z);
    }
}
