using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crossTheMenu : MonoBehaviour
{
    public inputJump player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick ()
    {
        player.loadLevel();
    }
}
