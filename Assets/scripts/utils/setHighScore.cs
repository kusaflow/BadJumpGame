using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setHighScore : MonoBehaviour
{
    public Text hs;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hs.text = globalVar.sd.highScore.ToString();
    }
}
