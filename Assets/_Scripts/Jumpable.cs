using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpable : MonoBehaviour
{
    public float JumpHeight = 20f;
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, JumpHeight, 0));
        }
    }
}
