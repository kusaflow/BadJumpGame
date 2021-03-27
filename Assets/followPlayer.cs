using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 pos;
            pos= player.transform.position;

            pos.x += 11.2f;
            pos.y += 2.8f;
            pos.z = -10;
            transform.position = pos;
        }
        
    }
}
