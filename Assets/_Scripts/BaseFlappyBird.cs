using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseFlappyBird : MonoBehaviour
{
    public float MoveSpeed = 0.2f;

    public void FixedUpdate()
    {
        this.transform.position += new Vector3(MoveSpeed, 0, 0);
    }

    public void OnCollisionEnter(Collision other)
    {
        GameManager gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        gm.isPlaying = false;
    }
}
