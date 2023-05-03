using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement playerMovementScript;


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Obstacle")
        {

            playerMovementScript.enabled = false;
            Debug.Log(collision.collider.name);

        }
    }
}
