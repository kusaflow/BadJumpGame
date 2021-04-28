using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s2FollowCam : MonoBehaviour
{
    public s2_handler player;
    public Camera cam;

    float yDif = 0;
    public float yDiffRange = 3.5f;
    public float camChangeSpeed = 4;

    public bool isConstY = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isConstY)
        {
            if (player.gravityIsPos)
            {
                if (yDif < yDiffRange)
                    yDif += camChangeSpeed * Time.deltaTime;
                else
                    yDif = yDiffRange;
            }
            else
            {
                if (yDif > -yDiffRange)
                    yDif -= camChangeSpeed * Time.deltaTime;
                else
                    yDif = -yDiffRange;
            }
        }


        
        //Debug.Log(cam.orthographicSize);
        //cam.fieldOfView;
        if (player != null)
        {
            Vector3 pos;
            pos = player.transform.position;

            pos.x += 7f;
            if (!isConstY)
                pos.y += yDif;
            else
                pos.y = yDiffRange;
            pos.z = -10;
            transform.position = pos;
        }

    }
}
