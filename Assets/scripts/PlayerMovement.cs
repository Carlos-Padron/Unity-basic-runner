using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    void Start()
    {
        // rb.AddForce(0,0,500);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
