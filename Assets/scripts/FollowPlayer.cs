using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public Transform player;
    public Vector3 offset;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = player.transform.position;
        Vector3 cameraPosition = gameObject.transform.position;
        gameObject.transform.position = playerPosition + offset;
    }
}
