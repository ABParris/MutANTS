using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour {
    public Rigidbody rb;
    public float fowardForce;
    public float sidwaysForce;
    public bool spacePressed = false;
    // Use this for initialization
    private void LateUpdate()
    {
        if(Input.GetKeyDown("space")){
            spacePressed = true;
        }
    }

    private void FixedUpdate()
    {
        if(spacePressed){
            spacePressed = false;
            rb.AddForce(0, 250, 0);
        }
        if(Input.GetKey("a")){
            rb.AddForce(sidwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce((-sidwaysForce) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0,0,(fowardForce+50)*Time.deltaTime,ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, (-fowardForce) * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
