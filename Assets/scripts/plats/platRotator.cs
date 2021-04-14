using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platRotator : MonoBehaviour
{

    public float speed = 10;
    public float rotTar = 60;
    bool isNeg = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.rotation.eulerAngles);
        Vector3 rot = transform.rotation.eulerAngles;
        if (isNeg)
        {
            if (transform.rotation.eulerAngles.z >= -1 * rotTar)
            {
                rot.z -= speed * Time.deltaTime;
            }
            else
            {
                isNeg = false;
            }
        }
        else
        {
            if (transform.rotation.eulerAngles.z <= 1 * rotTar)
            {
                rot.z += speed * Time.deltaTime;
            }
            else
            {
                isNeg = true;
            }
        }

        transform.rotation = Quaternion.Euler(rot.x, rot.y, rot.z);


        
    }

}
