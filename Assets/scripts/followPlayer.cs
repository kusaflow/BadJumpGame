using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cam.orthographicSize = 10 + (player.transform.position.y-3.5f)/2;
        //Debug.Log(cam.orthographicSize);
        //cam.fieldOfView;
        if (player != null)
        {
            Vector3 pos;
            pos= player.transform.position;

            pos.x += 7f;
            //pos.y += 2.8f;
            pos.z = -10;
            transform.position = pos;
        }
        
    }
}
