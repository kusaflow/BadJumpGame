using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scene1_menuShowData : MonoBehaviour
{
    // Start is called before the first frame update
    public Text prog;
    public Image b1;
    public Image b2;
    public Image b3;
    public Image b4;
    public Image b5;
    public Image b6;

    private void Start()
    {
        b1.color = new Color(1, 1, 1, 0);
        b2.color = new Color(1, 1, 1, 0);
        b3.color = new Color(1, 1, 1, 0);
        b4.color = new Color(1, 1, 1, 0);
        b5.color = new Color(1, 1, 1, 0);
        b6.color = new Color(1, 1, 1, 0);

    }

    // Update is called once per frame
    void Update()
    {

        prog.text = globalVar.sd.s1_progress.ToString() + "%";
        if (globalVar.sd.s1_hasB1)
            b1.color = Color.white;
        if (globalVar.sd.s1_hasB2)
            b2.color = Color.white;
        if (globalVar.sd.s1_hasB3)
            b3.color = Color.white;
        if (globalVar.sd.s1_hasB4)
            b4.color = Color.white;
        if (globalVar.sd.s1_hasB5)
            b5.color = Color.white;
        if (globalVar.sd.s1_hasB6)
            b6.color = Color.white;
        

    }
}
