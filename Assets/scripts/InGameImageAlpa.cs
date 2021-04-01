using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameImageAlpa : MonoBehaviour
{

    public inputJump imJ;
    public Image img;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color col = img.color;

        if (!imJ.isMouseDown && !imJ.isTouched)
        {
            if (col.a > 0)
                col.a -= 3 * Time.deltaTime ;
            if (col.a <= 0)
                col.a = 0;
        }
        else
        {
            float funnyAdder = 0;
            if (imJ.VerticalForceForJump >= 800)
            {
                funnyAdder = Random.Range(-.1f, .1f);
            }
            col.a = imJ.VerticalForceForJump / 1200 + funnyAdder;
        }

        img.color = col;
    }
}
