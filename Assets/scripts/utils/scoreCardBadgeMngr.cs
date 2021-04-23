using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCardBadgeMngr : MonoBehaviour
{
    public Image b1;
    public Image b2;
    public Image b3;
    public Image b4;
    public Image b5;
    public Image b6;

    // Start is called before the first frame update
    void Start()
    {

        if (globalVar.score >= 250)
        {
            b1.color = Color.white;
        }
        if (globalVar.score >= 500)
        {
            b2.color = Color.white;
        }
        if (globalVar.score >= 800)
        {
            b3.color = Color.white;
        }
        if (globalVar.score >= 1100)
        {
            b4.color = Color.white;
        }
        if (globalVar.score >= 1500)
        {
            b5.color = Color.white;
        }
        if (globalVar.score >= 1900)
        {
            b6.color = Color.white;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
