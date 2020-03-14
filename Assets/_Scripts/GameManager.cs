using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isPlaying = true;

    // bird
    public BaseFlappyBird baseFlappyBird;
    public Jumpable jumpable;

    // score stuff


    // Start is called before the first frame update
    void Start()
    {
        baseFlappyBird.enabled = isPlaying;
        jumpable.enabled = isPlaying;
    }

    // Update is called once per frame
    void Update()
    {
        baseFlappyBird.enabled = isPlaying;
        jumpable.enabled = isPlaying;
    }
}
