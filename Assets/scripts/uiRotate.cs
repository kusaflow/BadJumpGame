using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiRotate : MonoBehaviour
{

    public Image img;
    public float rotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    } 

    // Update is called once per frame
    void Update()
    {
        //Vector3 pos = img.transform.position;
        //pos.x++;
        //img.transform.position = pos;


        Quaternion rot = img.transform.rotation;
        rot.z += rotSpeed * Time.deltaTime;
        img.transform.rotation = rot;
    }
}
