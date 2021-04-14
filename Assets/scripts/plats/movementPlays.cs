using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementPlays : MonoBehaviour
{

    public bool isUpDown = true;
    Vector3 pos;
    bool moveIn_L_D = false;

    float moveL = 5;
    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        moveL = Random.Range(1,10);
        speed = Random.Range(1, 6);
    }

    // Update is called once per frame
    void Update()
    {
        if (isUpDown)
        {
            //up Down
            if (moveIn_L_D)
            {
                //move down
                if (transform.position.y >= pos.y - moveL)
                {
                    transform.position = new Vector3(pos.x, transform.position.y - speed * Time.deltaTime, pos.z);
                }
                else
                {
                    moveIn_L_D = false;
                }
            }
            else
            {
                //move up
                if (transform.position.y <= pos.y + moveL)
                {
                    transform.position = new Vector3(pos.x, transform.position.y + speed * Time.deltaTime, pos.z);
                }
                else
                {
                    moveIn_L_D = true;
                }
            }
        }
    }
}
