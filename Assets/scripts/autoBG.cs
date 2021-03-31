using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoBG : MonoBehaviour
{

    public GameObject bg1;
    float CurdrawPos = -15;
    float nextMilestone = 200;
    float posAdder = 20.4f;

    Queue<GameObject> bgQ = new Queue<GameObject>();



    // Start is called before the first frame update
    void Start()
    {
        for (int i =0; i< 16; i++)
        {
            GameObject bg = (GameObject)Instantiate(bg1, new Vector3(CurdrawPos, 0, 10), new Quaternion());
            bgQ.Enqueue(bg);

            CurdrawPos += posAdder;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (nextMilestone <= transform.position.x)
        {
            nextMilestone = CurdrawPos;
            for (int i = 0; i < 5; i++)
            {
                GameObject bg = (GameObject)Instantiate(bg1, new Vector3(CurdrawPos, 0, 10), new Quaternion());
                bgQ.Enqueue(bg);
                Destroy(bgQ.Dequeue());
                CurdrawPos += posAdder;
            }
        }
    }
}
